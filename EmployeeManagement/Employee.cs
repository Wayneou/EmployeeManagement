﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //資料庫連線 安裝:NuGet套件管理員 --> 管理方案 --> System.Data.SqlClient

namespace EmployeeManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        //建立資料庫連線物件 con
        //點選Employeedb後會出現屬性，找到連接字串的欄位，複製連接字串。"@Data Source=SqlConnection" 有特殊符號才用@
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P6CBMS9;Initial Catalog=Employeedb;Integrated Security=True");

        //方法 : 資料繫結
        //使用ADO.NET來連接SQL Sever執行查詢並將數據顯示在 DataGridView 控制項上
        void BindData()
        {
            //建立 SqlCommand 物件 cnn   (資料庫查詢語法 , 資料庫連線物件)
            SqlCommand cnn = new SqlCommand("Select * from emptab", con);

            //SqlDataAdapter 是用來連接資料庫和 DataTable 之間的連接器。SqlCommand物件 cnn 作為參數傳入，來執行查詢並接收返回的數據。
            SqlDataAdapter da = new SqlDataAdapter(cnn);

            //建立DataTable物件
            DataTable table = new DataTable();

            //SqlDataAdapter 的 Fill 方法用於執行 SQL 查詢 將DataTable物件 table 當作參數傳入 Fill() 並將查詢結果填充到 DataTable 中。這個過程會自動開啟數據庫連接執行查詢，然後關閉連接。
            da.Fill(table);

            //dgv員工是設計Form的時候命名 將AutoSizeColumnsMode 調成 Fill 列寬自動調整以填滿dgv員工的可用顯示區域
            //DataGridView 將顯示 DataTable 中的所有行和列
            dgv員工.DataSource = table; 
        }
        //將EmployeeForm中的StartPosition 調成 CenterScreen

        //當程式載入時資料庫會連線
        private void Employee_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void btn加入_Click(object sender, EventArgs e)
        {
            //開啟資料庫連接
            con.Open();

            //SqlCommand 物件，用於執行 SQL 插入語句。這個語句將新的員工資料插入到 emptab 表格。使用參數化查詢 (@id, @employeename, 等) 來防止 SQL 注入攻擊，並提高代碼的安全性。
            SqlCommand cnn = new SqlCommand("Insert into emptab(id,employeename,age,email,salary,dob,benefit) values(@id,@employeename,@age,@email,@salary,@dob,@benefit)",con);

            //AddWithValue 方法調用都將文本框中的值轉換為適當的數據類型並將其添加到 SQL 查詢的對應參數中。
            cnn.Parameters.AddWithValue("@Id", int.Parse(txtboxID.Text));
            cnn.Parameters.AddWithValue("@EmployeeName", txtbox姓名.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(txtbox年齡.Text));
            cnn.Parameters.AddWithValue("@Email", txtbox電子郵件.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(txtbox薪資.Text));
            cnn.Parameters.AddWithValue("@Dob", DateTime.Parse(txtbox生日.Text));
            cnn.Parameters.AddWithValue("@Benefit", txtbox福利.Text);

            //ExecuteNonQuery 方法用於執行 SQL 語句（如插入、更新或刪除），這裡用來將資料插入資料庫。
            cnn.ExecuteNonQuery();

            //關閉資料庫連接
            con.Close();

            //更新DataGridView，用來從數據庫讀取數據並綁定到 DataGridView。
            BindData();

            //到Program.cs先測試Employee
        }

        //當加入新員工後要繼續增加下一位 清空欄位
        private void btn新增_Click(object sender, EventArgs e)
        {
            txtboxID.Text = "";
            txtbox姓名.Text = "";
            txtbox年齡.Text = "";
            txtbox電子郵件.Text = "";
            txtbox薪資.Text = "";
            txtbox生日.Text = "";
            txtbox福利.Text = "";
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Delete emptab where id=@id", con);

            //輸入ID來刪除資料
            cnn.Parameters.AddWithValue("@Id", int.Parse(txtboxID.Text));

            //ExecuteNonQuery 方法用於執行 SQL 語句（如插入、更新或刪除），這裡用來刪除資料庫中的資料。
            cnn.ExecuteNonQuery();

            con.Close();

            //MessageBox.Show 方法來顯示一個彈出對話框，這是在進行數據刪除等敏感操作前，來確保使用者有意識到他們的操作可能帶來的後果。
            //MessageBox.Show("確定要刪除此筆資料嗎?");
            MessageBox.Show("確定要刪除此筆資料嗎?","刪除確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //更新DataGridView，用來從數據庫讀取數據並綁定到 DataGridView。
            BindData();
        }
    }
}
