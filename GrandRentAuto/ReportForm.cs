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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string sql = @"SELECT Name,
       Address,
       Count(AvailableCars.CarID) AS nCars,
       count(txPickup.TxID)       AS nPickups,
       COUNT(txDropoff.TxID)      AS nDropoffs,
       COUNT(E.EmployeeID)        AS nEmployees
FROM Branches
         LEFT OUTER JOIN Transactions txPickup ON Branches.BranchID = txPickup.PickUpBranch
         LEFT JOIN Transactions txDropoff ON Branches.BranchID = txDropoff.ReturnBranch
         LEFT JOIN (SELECT * FROM Cars WHERE Status = 'available') as AvailableCars
                   ON Branches.BranchID = AvailableCars.StoredBranch
         LEFT JOIN Employees E on Branches.BranchID = E.WorksAt
GROUP BY BranchID, Name, Address ";
            if (checkBox1.Checked)
            {
                sql += " HAVING  Count(AvailableCars.CarID) > 0";
            }
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listView1);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
