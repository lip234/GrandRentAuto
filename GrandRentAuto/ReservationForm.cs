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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LoadComboBoxes();

            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
                if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a car");
                return;
            }
            DateTime pickup, dropoff;
            pickup = dateTimePickerSrart.Value;
            dropoff = dateTimePickerEnd.Value;
            int carID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string sql = "INSERT INTO Transactions (CustomerID, CarID, StartDate,ReturnDate, PickupBranch, ReturnBranch) " +
                "VALUES((SELECT CustomerID from Customers WHERE (FirstName + ' ' + LastName) = @cusname),@carid, @start, @return, @branch, @branch)";

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@cusname", SqlDbType.NVarChar).Value = textBoxName.Text.Trim();
                cmd.Parameters.Add("@carid", SqlDbType.NVarChar).Value = carID;
                cmd.Parameters.Add("@start", SqlDbType.NVarChar).Value = pickup;
                cmd.Parameters.Add("@return", SqlDbType.NVarChar).Value = dropoff;
                cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = MainForm.branchId;
                cmd.ExecuteNonQuery();
            }
            textBoxName.Clear();   
            panel1.Visible = false;
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = @"SELECT TxID,
       (C.FirstName + ' ' + C.LastName) AS FullName,
       C2.PlateNumber,
       T.StartDate,
       T.ReturnDate,
       B.Name
FROM Transactions T
         LEFT JOIN Customers C on T.CustomerID = C.CustomerID
         LEFT JOIN Cars C2 on T.CarID = C2.CarID
         LEFT JOIN Branches B ON B.BranchID = C2.StoredBranch";

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                if (checkBoxShowCurrentBranch.Checked)
                {
                    sql += " WHERE B.BranchID=@bid";
                    cmd.Parameters.Add("@bid", SqlDbType.Int).Value = MainForm.branchId;
                }
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listView1);
                }
            }
        }

        private void checkBoxShowCurrentBranch_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadComboBoxes()
        {
            comboBoxTypes.Items.Add("(ALL)");
            comboBoxTypes.SelectedIndex = 0;
            DBUtil.PopulateComboxBoxSQL("SELECT Description FROM CarTypes", comboBoxTypes, false);

            comboBoxBranches.Items.Add("(ALL)");
            comboBoxBranches.SelectedIndex = 0;
            DBUtil.PopulateComboxBoxSQL("SELECT Name FROM Branches", comboBoxBranches, false);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int txID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            int carID, branchID;
            string customerName;
            string sql = @"SELECT 
       (C.FirstName + ' ' + C.LastName) AS FullName,
       C2.CarID,
       B.BranchID
FROM Transactions T
         LEFT JOIN Customers C on T.CustomerID = C.CustomerID
         LEFT JOIN Cars C2 on T.CarID = C2.CarID
         LEFT JOIN Branches B ON B.BranchID = C2.StoredBranch WHERE TxID=@txid";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@txid", SqlDbType.Int).Value = txID;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    customerName = reader.GetString(0);
                    carID = reader.GetInt32(1);
                    branchID = reader.GetInt32(2);
                }
                if (branchID != MainForm.branchId)
                {
                    MessageBox.Show("Car is not located at this branch!");
                    return;
                }
                cmd.CommandText = @"UPDATE Cars SET Status=@status WHERE CarID=@carid;
UPDATE Transactions SET PickUpBranch=@branch, startDate=@date; 
";
                cmd.Parameters.Add("@carid", SqlDbType.Int).Value = carID;
                cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainForm.branchId;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = $"With Customer {customerName}";
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Transaction Updated!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int txID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            int carID, pickupBranch, CustomerID;
            DateTime pickupDate, returnDate;
            returnDate = DateTime.Now;
            decimal dailyRate, weeklyRate, monthlyRate, changebranchFee, totalCost;
            string sql = @"SELECT 
       C2.CarID,
       C.CustoemrID,
       T.PickUpBranch,
       T.PickUpDate
FROM Transactions T
         LEFT JOIN Customers C on T.CustomerID = C.CustomerID
         LEFT JOIN Cars C2 on T.CarID = C2.CarID
         LEFT JOIN Branches B ON B.BranchID = C2.StoredBranch WHERE TxID=@txid";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@txid", SqlDbType.Int).Value = txID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    carID = reader.GetInt32(0);
                    CustomerID = reader.GetInt32(1);
                    pickupBranch = reader.GetInt32(2);
                    pickupDate = reader.GetDateTime(3);
                }
                cmd.CommandText = @"UPDATE Cars SET Status=@status, StoredAt=@branch WHERE CarID=@carid;
UPDATE Transactions SET ReturnBranch=@branch, ActualReturnDate=@date; 
";
                cmd.Parameters.Add("@carid", SqlDbType.Int).Value = carID;
                cmd.Parameters.Add("@branch", SqlDbType.Int).Value = MainForm.branchId;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = returnDate;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "available";
                cmd.ExecuteNonQuery();
            }


            sql = @"SELECT RateDaily, rateWeekly, RateMonthly, ChangeBranchFee " +
                    "FROM Cars " +
                    "LEFT JOIN CarTypes ON Cars.Type = CarTypes.TypeID " +
                    "WHERE CarID=@carid";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@carid", SqlDbType.Int).Value = carID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    dailyRate = reader.GetDecimal(0);
                    weeklyRate = reader.GetDecimal(1);
                    monthlyRate = reader.GetDecimal(2);
                    changebranchFee = reader.GetDecimal(3);
                }
            }
            TimeSpan timeSpan = returnDate.Subtract(pickupDate);
            int nMonths, nWeeks, nDays;

            nMonths = (int) Math.Ceiling(timeSpan.TotalDays / 30);
            nWeeks = (int)Math.Ceiling(timeSpan.TotalDays / 7);
            nDays = (int)Math.Ceiling(timeSpan.TotalDays);

            // Find the minimum cost when charged by days, weeks or months
            totalCost = Math.Min(dailyRate * nDays, weeklyRate * nWeeks);
            totalCost = Math.Min(totalCost, monthlyRate * nMonths);

            if (pickupBranch != MainForm.branchId)
            {
                totalCost += changebranchFee;
            }
            MessageBox.Show($"Car returned! Total rental cost is ${totalCost.ToString("C")} ." );
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime pickup, dropoff;
            pickup = dateTimePickerSrart.Value;
            dropoff = dateTimePickerEnd.Value;
            string sql = "SELECT PlateNumber, Description, RateDaily, RateWeekly, RateMonthly, Branches.Name, Address, City, Province, PostalCode FROM Cars " +
                  "LEFT JOIN CarTypes ON Type=TypeID " +
                  "LEFT JOIN Branches ON StoredBranch = BranchID " +
                  "WHERE NOT EXISTS (SELECT 1 FROM Transactions " +
                                      "WHERE StartDate BETWEEN @pickup AND @dropoff " +
                                      "OR ReturnDate BETWEEN @pickup AND @dropoff " +
                                      "OR (StartDate < @pickup AND ReturnDate > @dropoff)) ";

            if (!comboBoxTypes.SelectedItem.ToString().Equals("(ALL)"))
            {
                sql += " AND Type = (SELECT TypeID From CarTypes WHERE Description = @type) ";
            }

            if (!comboBoxBranches.SelectedItem.ToString().Equals("(ALL)"))
            {
                sql += " AND Storedbranch = (SELECT branchID From Branches WHERE Name = @branch) ";
            }
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@pickup", SqlDbType.DateTime).Value = pickup;
                cmd.Parameters.Add("@dropoff", SqlDbType.DateTime).Value = dropoff;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = comboBoxTypes.SelectedItem.ToString();
                cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = comboBoxBranches.SelectedItem.ToString();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listView1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
        }
    }
}
