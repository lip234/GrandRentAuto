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
    public partial class CustomerCarsForm : Form
    {
        private int customerID;
        public CustomerCarsForm(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }
        private void LoadData()
        {
            DateTime pickup, dropoff;
            pickup = dateTimePickup.Value;
            dropoff = dateTimeReturn.Value;
            string sql = "SELECT PlateNumber, Description, RateDaily, RateWeekly, RateMonthly, Branches.Name, Address, City, Province, PostalCode FROM Cars " +
                    "LEFT JOIN CarTypes ON Type=TypeID " +
                    "LEFT JOIN Branches ON StoredBranch = BranchID " +
                    "WHERE NOT EXISTS (SELECT 1 FROM Transactions " +
                                        "WHERE StartDate BETWEEN @pickup AND @dropoff " +
                                        "OR ReturnDate BETWEEN @pickup AND @dropoff " +
                                        "OR (StartDate < @pickup AND ReturnDate > @dropoff)) ";
            if (radioMyCity.Checked)
            {
                sql += " AND City = (SELECT City From Customers WHERE CustomerID = @customerID) ";
            }
            if (radioCustomCity.Checked)
            {
                sql += " AND City = @city ";
            }
            if (radioMyProvince.Checked)
            {
                sql += " AND Province = (SELECT Province From Customers WHERE CustomerID = @customerID) ";
            }
            if (radioCustomProvince.Checked)
            {
                sql += " AND Province = @province ";
            }

            if (!comboBoxTypes.SelectedItem.ToString().Equals("(ALL)"))
            {
                sql += " AND Type (SELECT TypeID From CarTypes WHERE Description = @type) ";
            }

            if (!comboBoxBranches.SelectedItem.ToString().Equals("(ALL)"))
            {
                sql += " AND StoredAt (SELECT branchID From Branches WHERE Name = @branch) ";
            }

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@pickup", SqlDbType.DateTime).Value = pickup;
                cmd.Parameters.Add("@dropoff", SqlDbType.DateTime).Value = dropoff;
                cmd.Parameters.Add("@customerID", SqlDbType.Int).Value = customerID;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = textCity.Text.Trim();
                cmd.Parameters.Add("@province", SqlDbType.NVarChar).Value = textProvince.Text.Trim();
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = comboBoxTypes.SelectedItem.ToString();
                cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = comboBoxBranches.SelectedItem.ToString();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listView1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CustomerBranchForm_Load(object sender, EventArgs e)
        {
            comboBoxTypes.Items.Add("(ALL)");
            comboBoxTypes.SelectedIndex = 0;
            DBUtil.PopulateComboxBoxSQL("SELECT Description FROM CarTypes", comboBoxTypes, false);

            comboBoxBranches.Items.Add("(ALL)");
            comboBoxBranches.SelectedIndex = 0;
            DBUtil.PopulateComboxBoxSQL("SELECT Name FROM Branches", comboBoxBranches, false);
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
