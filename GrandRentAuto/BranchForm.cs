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
    public partial class BranchForm : Form
    {
        public BranchForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid branch name!");
                return;
            }
            if (textBoxAddress.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid address!");
                return;
            }
            if (textBoxCity.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid city!");
                return;
            }
            if (textBoxProvince.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid Province!");
                return;
            }
            if (textBoxPostalCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a valid postal code!");
                return;
            }
            string sql = "INSERT INTO Branches(Name, Address, City, Province, PostalCode) values (@name, @addr, @city, @prov, @postal)";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxName.Text;
                cmd.Parameters.Add("@addr", SqlDbType.NVarChar).Value = textBoxAddress.Text;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
                cmd.Parameters.Add("@prov", SqlDbType.NVarChar).Value = textBoxProvince.Text;
                cmd.Parameters.Add("@postal", SqlDbType.NVarChar).Value = textBoxPostalCode.Text;
                cmd.ExecuteNonQuery();
            }
            LoadBranchesListView();
            MessageBox.Show("Success!");
            ClearAddPanel();
            panel1.Visible = false;
        }

        private void ClearAddPanel()
        {
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxCity.Clear();
            textBoxProvince.Clear();
            textBoxPostalCode.Clear();
        }
        private void LoadBranchesListView()
        {
            string sql = "SELECT  * FROM branches";
            using(SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listViewBranch);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to discard unsaved changes?", "Discard?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ClearAddPanel();
                panel1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selectedBranch = listViewBranch.SelectedItems[0];
            if (selectedBranch == null) return;

            string branchName = selectedBranch.SubItems[1].Text;
            int branchID = Int32.Parse(selectedBranch.SubItems[0].Text);

            // Check employees
            string sql = "SELECT EmployeeID FROM Employees WHERE WorksAt=@branch";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@branch", SqlDbType.Int).Value = branchID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("They are employees that work at this branch! ");
                        return;
                    }
                }
            }

            // Check Cars 
            sql = "SELECT CarID from Cars WHERE StoredBranch=@branch";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@branch", SqlDbType.Int).Value = branchID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        MessageBox.Show("They are cars stored at this branch!");
                        return;
                    }
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete branch " + branchName + "?",
                                                    "Delete?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes )
            {
                sql = "DELETE branches where BranchID = @branch";
                using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection())) {
                    cmd.Parameters.Add("@branch", SqlDbType.Int).Value = branchID;
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Success!");
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            LoadBranchesListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
