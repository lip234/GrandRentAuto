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

namespace GrandRentAuto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            SqlConnection conn;
            try
            {
                 conn = DBUtil.GetConnection();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Unable to connect to the database. Please contact support! Error: " + e.Message);
                return;
            }

            string sql;

            if (radioStaff.Checked)
            {
                sql = "SELECT employeeID, FirstName + ' ' + LastName as FullName, BranchID, Branches.Name FROM Employees " +
                    "LEFT JOIN Branches ON WorksAt = BranchID " +
                    "WHERE (FirstName + ' ' + LastName)=@name";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxName.Text.Trim();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Employee " + textBoxName.Text.Trim() + " Doesn't exist!");
                            return;
                        }
                        reader.Read();
                        MainForm.employeeID = reader.GetInt32(0);
                        MainForm.employeeName = reader.GetString(1);
                        MainForm.branchId = reader.GetInt32(2);
                        MainForm.branchName = reader.GetString(3);
                        Form form = new MainForm();
                        form.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
#if DEBUG
                Form form = new CustomerCarsForm(1);
                form.ShowDialog();
                return;
#endif
                sql = "select CustomerID as FullName from Customers where (FirstName + ' ' + LastName)= @name";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxName.Text.Trim();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Customer " +textBoxName.Text.Trim() + " Doesn't exist!");
                            return;
                        }
                        reader.Read();
                        int customerID = reader.GetInt32(0);
                        Form customerMain = new CustomerCarsForm(customerID);
                        this.Hide();
                        customerMain.ShowDialog();
                    }
                }
            }
        }
    }
}
