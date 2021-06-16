using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GrandRentAuto
{
    public partial class MainForm : Form
    {
        public static  int employeeID { get; set; }
        public static string employeeName { get; set; }
        public static int branchId { get; set; }
        public static string branchName { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form carForm = new CarForm();
            carForm.ShowDialog();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form emplyeeForm = new EmployeeForm();
            emplyeeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new BranchForm();
            form.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new ReservationForm();
            form.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBUtil.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label1.Text = "Logged in as " + employeeName + " at branch " + branchName;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Form form = new ReportForm();
            form.ShowDialog();
        }
    }
}
