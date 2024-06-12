using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn員工_Click(object sender, EventArgs e)
        {
            Employee employeeInfo = new Employee();
            employeeInfo.Show();
        }

        private void btn員工資料_Click(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo();
            employeeInfo.Show();
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            MessageBox.Show("確定要離開嗎?", "確認離開", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
