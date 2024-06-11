using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-P6CBMS9;Initial Catalog=Employeedb;Integrated Security=True");

        private void btn顯示員工資料_Click(object sender, EventArgs e)
        {
            //建立了 SqlCommand 物件 cnn   (資料庫查詢語法 , 資料庫連線物件)
            SqlCommand cnn = new SqlCommand("Select * from emptab", con);

            //SqlDataAdapter 是用來連接資料庫和 DataTable 之間的連接器。SqlCommand物件 cnn 作為參數傳入，來執行查詢並接收返回的數據。
            SqlDataAdapter da = new SqlDataAdapter(cnn);

            //建立DataTable物件
            DataTable table = new DataTable();

            //SqlDataAdapter 的 Fill 方法用於執行 SQL 查詢 將DataTable物件 table 當作參數傳入 Fill() 並將查詢結果填充到 DataTable 中。這個過程會自動開啟數據庫連接執行查詢，然後關閉連接。
            da.Fill(table);

            //dgv員工是設計Form的時候命名 將AutoSizeColumnsMode 調成 Fill 列寬自動調整以填滿dgv員工的可用顯示區域
            //DataGridView 將顯示 DataTable 中的所有行和列
            dgv員工資料.DataSource = table;
        }
    }
}
