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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxBranches.SelectedItem == null)
            {
                MessageBox.Show("Please select a branch!");
                return;
            }
            string sql;
            if (checkBoxEdit.Checked)
            {
                sql = "UPDATE Employees SET FirstName=@fName, LastName =@lName,City=@city, Province=@province, " +
                    "WorksAt=(SELECT BranchID FROM Branches WHERE Name=@branch) " +
                    "WHERE EmployeeID =@eid";
            }
            else
            {
                sql = "INSERT INTO Employees(FirstName, LastName, City, Province, WorksAt) Values " +
                  "(@fName, @lName, @city, @province, (SELECT BranchID FROM Branches WHERE Name=@branch))";
            }

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@fName", SqlDbType.NVarChar).Value = textBoxfName.Text.Trim();
                cmd.Parameters.Add("@lName", SqlDbType.NVarChar).Value = textBoxlName.Text.Trim();
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text.Trim();
                cmd.Parameters.Add("@province", SqlDbType.NVarChar).Value = textBoxProvince.Text.Trim();
                cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = comboBoxBranches.SelectedItem.ToString();
                if (checkBoxEdit.Checked)
                {
                    int employeeID = int.Parse(textBoxEID.Text);
                    cmd.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
                }

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    MessageBox.Show("Error making changes to the database! Error info: " + err.Message, "Error!");
                    return;
                }
                finally
                {
                    ClearPanel();
                }
                MessageBox.Show("Successful!");
                LoadData();
            }
        }

        private void ClearPanel()
        {
            textBoxfName.Clear();
            textBoxlName.Clear();
            textBoxCity.Clear();
            textBoxProvince.Clear();
            comboBoxBranches.Items.Clear();
            checkBoxEdit.Checked = false;
            textBoxEID.Clear();
            DBUtil.PopulateComboxBoxSQL("SELECT Name From Branches", comboBoxBranches);
        }

        private void LoadData()
        {
            string sql = "SELECT EmployeeID, FirstName, LastName, E.City, E.Province, B.Name From Employees E " +
                "LEFT JOIN Branches B ON E.WorksAt = B.BranchID";
            using(SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listViewEmployee);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems.Count == 0)
            {
                return;
            }

            int employeeID = int.Parse(listViewEmployee.SelectedItems[0].SubItems[0].Text);
            string fName = listViewEmployee.SelectedItems[0].SubItems[1].Text;
            string lName = listViewEmployee.SelectedItems[0].SubItems[2].Text;

            DialogResult result = MessageBox.Show($"Are you sure you want to delete employee {fName} {lName}?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Employees where EmployeeID = @eid";
                using(SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
                {
                    cmd.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show($"Employee {fName} {lName} deleted!");
                LoadData();
            }
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedItems == null)
            {
                return;
            }
            ClearPanel();
            int employeeID = int.Parse(listViewEmployee.SelectedItems[0].SubItems[0].Text);
            string sql = "SELECT FirstName, LastName, E.City, E.Province, B.Name From Employees E " +
                         "LEFT JOIN Branches B ON E.WorksAt = B.BranchID " +
                         "WHERE EmployeeID = @eid";

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    textBoxfName.Text = reader.GetString(0);
                    textBoxlName.Text = reader.GetString(1);
                    textBoxCity.Text = reader.GetString(2);
                    textBoxProvince.Text = reader.GetString(3);
                    comboBoxBranches.SelectedItem = reader.GetString(4);
                    checkBoxEdit.Checked = true;
                    textBoxEID.Text = employeeID.ToString();
                    panel1.Show();
                }
            }
        }
    }
}
