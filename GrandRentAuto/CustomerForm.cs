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
    public partial class CustomerForm : Form
    {
        // for editing.
        private bool Editing = false;
        private int CustomerID;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Visible = true;

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string sql = @"SELECT C.CustomerID,
       FirstName,
       LastName,
       City,
       Province,
       CASE
           WHEN (COUNT(TY.CustomerID)) >= 3 then 'YES'
           ELSE 'NO'
       END AS IsGoldMember,
       COUNT(T.TxID) AS TotalRentals
FROM Customers C
         LEFT JOIN Transactions T on C.CustomerID = T.CustomerID
         LEFT JOIN (SELECT TxID, CustomerID FROM Transactions where YEAR(StartDate) = YEAR(GETDATE())) TY
                   on C.CustomerID = TY.CustomerID
GROUP BY C.CustomerID, FirstName, LastName, City, Province ";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listViewCustomer);
                }
            }
        }

        private void ClearPanel()
        {
            Editing = false;
            textBoxfName.Clear();
            textBoxlName.Clear();
            textBoxAddr.Clear();
            textBoxCity.Clear();
            textBoxProvince.Clear();
            textBoxPostalCode.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sql;
            if (Editing)
            {
                sql = "UPDATE Customers SET FirstName=@fName, LastName=@lName, Address=@address,City=@city, " +
                    "Province=@province, PostalCode=@postalcode WHERE CustomerID = @cid";
            }
            else
            {
                sql = "INSERT INTO Customers (FirstName, LastName, Address, City, Province, PostalCode) " +
                    "VALUES (@fName, @lName, @address, @city, @province, @postalcode)";
            }
            using(SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@fName", SqlDbType.NVarChar).Value = textBoxfName.Text.Trim();
                cmd.Parameters.Add("@lName", SqlDbType.NVarChar).Value = textBoxlName.Text.Trim();
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = textBoxAddr.Text.Trim();
                cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text.Trim();
                cmd.Parameters.Add("@province", SqlDbType.NVarChar).Value = textBoxProvince.Text.Trim();
                cmd.Parameters.Add("@postalcode", SqlDbType.NVarChar).Value = textBoxPostalCode.Text.Trim();
                if (Editing)
                {
                    cmd.Parameters.Add("cid", SqlDbType.Int).Value = CustomerID;
                }
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ee)
                {
                    MessageBox.Show("Error saving changes to database! Error Message " + ee.ToString());
                    return;
                }
                finally
                {
                    ClearPanel();
                    LoadData();
                    panel1.Visible = false;
                }
                MessageBox.Show("Success!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count == 0 )
            {
                return;
            }
            CustomerID = int.Parse(listViewCustomer.SelectedItems[0].SubItems[0].Text);
            Editing = true;
            string sql = "SELECT FirstName, LastName, Address, City, Province, PostalCode FROM Customers " +
                "WHERE CustomerID = @cid";
            using(SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@cid", SqlDbType.Int).Value = CustomerID;
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    textBoxfName.Text = reader.GetString(0);
                    textBoxlName.Text = reader.GetString(1);
                    textBoxAddr.Text = reader.GetString(2);
                    textBoxCity.Text = reader.GetString(3);
                    textBoxProvince.Text = reader.GetString(4);
                    textBoxPostalCode.Text = reader.GetString(5);
                }
            }
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewCustomer.SelectedItems.Count == 0)
            {
                return;
            }
            CustomerID = int.Parse(listViewCustomer.SelectedItems[0].SubItems[0].Text);
            string fName = listViewCustomer.SelectedItems[0].SubItems[1].Text;
            string lName = listViewCustomer.SelectedItems[0].SubItems[2].Text;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete customer {fName} {lName}?",
                "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "DELETE FROM Customers Where CustomerID = @cid";
                using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
                {
                    cmd.Parameters.Add("@cid", SqlDbType.Int).Value = CustomerID;
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ee)
                    {
                        MessageBox.Show("Error Deleting Customer! Error Message: " + ee.ToString());
                    }
                    finally
                    {
                        LoadData();
                    }
                }
            }
        }
    }
}
