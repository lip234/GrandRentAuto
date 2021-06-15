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
    public partial class CarForm : Form
    {
        private Form mainMenu;

        public CarForm(Form mainMenu)
        {
            this.mainMenu = mainMenu;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadBranchComboBox();
            LoadTypeCombobox();
            panelAdd.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int mileage; 
            if (!Int32.TryParse(textBoxMilage.Text, out mileage))
            {
                MessageBox.Show("Mileage must be an integer!");
                return;
            }

            string sql = "Insert into Cars (PlateNumber, StoredBranch, Type, Mileage, Status) " +
                 "Values (@plate, " +
                 "(SELECT BranchID FROM Branches WHERE Name = @branch)," +
                 "(SELECT TypeID from CarTypes where Description = @type)," +
                 "@mileage, @status)";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                cmd.Parameters.Add("@plate", SqlDbType.NVarChar).Value = textboxPlate.Text;
                cmd.Parameters.Add("@branch", SqlDbType.NVarChar).Value = (string)comboBoxStoredAt.SelectedItem;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = (string)comboBoxTypes.SelectedItem;
                cmd.Parameters.Add("@mileage", SqlDbType.Int).Value = mileage;
                // Hard-coded for now
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "availabe";
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Success!");
            LoadCarListView();
            textboxPlate.Clear();
            textBoxMilage.Clear();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            LoadTypeList();
            LoadCarListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnSaveType_Click(object sender, EventArgs e)
        {
            string desc;
            Double dailyRate, weeklyRate, monthlyRate, changeBranchFee;
            desc = textBox_typeDesc.Text;
            dailyRate = double.Parse(textBox_dailyRate.Text, System.Globalization.NumberStyles.Currency);
            weeklyRate = double.Parse(textBox_weeklyRate.Text, System.Globalization.NumberStyles.Currency);
            monthlyRate = double.Parse(textBox_monthlyRate.Text, System.Globalization.NumberStyles.Currency);
            changeBranchFee = double.Parse(textBox_changeFee.Text, System.Globalization.NumberStyles.Currency);


            if (desc.Length == 0)
            {
                MessageBox.Show("Please type a valid descrption!");
                return;
            }
            if (dailyRate <= 0)
            {
                MessageBox.Show("Invalid daily rate!");
                return;
            }
            if (weeklyRate <= 0)
            {
                MessageBox.Show("Invalid Weekly rate!");
                return;
            }
            if (monthlyRate <= 0)
            {
                MessageBox.Show("Invalid monthly rate!");
                return;
            }

            string sql = "INSERT INTO CarTypes " +
                "(Description, RateDaily, RateWeekly, RateMonthly, ChangeBranchFee)" +
                "VALUES (@desc, @daily,@weekly,@monthly,@changeBranch)";
            var sqlcommand = new SqlCommand(sql, DBUtil.GetConnection());
            sqlcommand.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc;
            sqlcommand.Parameters.Add("@daily", SqlDbType.Decimal).Value = dailyRate;
            sqlcommand.Parameters.Add("@weekly", SqlDbType.Decimal).Value = weeklyRate;
            sqlcommand.Parameters.Add("@monthly", SqlDbType.Decimal).Value = monthlyRate;
            sqlcommand.Parameters.Add("@changeBranch", SqlDbType.Decimal).Value = changeBranchFee;
            sqlcommand.ExecuteNonQuery();
            MessageBox.Show("Car type " + desc + " added!");
            textBox_typeDesc.Clear();
            textBox_dailyRate.Clear();
            textBox_weeklyRate.Clear();
            textBox_monthlyRate.Clear();
            textBox_changeFee.Clear();
            panel1.Visible = false;
            LoadTypeCombobox();
        }

        private void amountBox_Leave(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            Double amount;
            if (double.TryParse(box.Text, out amount))
            {
                box.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", amount);
            }
        }
        private void LoadTypeList()
        {
            string sql = "SELECT * FROM CarTypes";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateListView(reader, listView_types);
                }
            }
        }

        private void LoadTypeCombobox()
        {
            string sql = "select Description from CarTypes";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DBUtil.PopulateCombobox(reader, comboBoxTypes);
                }
            }
        }

        private void LoadBranchComboBox()
        {
            string sql = "SELECT Name FROM Branches";
            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader()) 
                { 
                    DBUtil.PopulateCombobox(reader, comboBoxStoredAt);
                }
            }
        }

        private void LoadCarListView()
        {
            string sql = "SELECT Cars.CarID, PlateNumber, Branches.Name, CarTypes.Description, Mileage, Status " +
                    "FROM Cars " +
                    "LEFT JOIN CarTypes ON Cars.Type = CarTypes.TypeID " +
                    "LEFT JOIN Branches ON Cars.StoredBranch = Branches.BranchID " +
                    "WHERE 1=1 ";
            SqlCommand cmd;
            if (textBoxFilter.Text.Trim().Length > 0)
            {
                switch ((string)comboBoxFilterBy.SelectedItem)
                {
                    case "Branch Name":
                        sql += "AND BranchName LIKE @param";
                        break;
                    case "City":
                        sql += "AND City LIKE @param";
                        break;
                    case "Type":
                        sql += "AND Description LIKE @param";
                        break;
                }
                cmd = new SqlCommand(sql, DBUtil.GetConnection());
                cmd.Parameters.Add("@param", SqlDbType.VarChar).Value = '%' + textBoxFilter.Text.Trim() + '%';
            }
            else
            {
                cmd = new SqlCommand(sql, DBUtil.GetConnection());
            }
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                DBUtil.PopulateListView(reader, listViewCars);
            }
        }

        private void listViewCars_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();

                MenuItem edit = new MenuItem("Edit");
                edit.Click += listViewCars_EditItem;
                menu.MenuItems.Add(edit);
                
                MenuItem delete = new MenuItem("Delete");
                edit.Click += listViewCars_DeleteItem;
                menu.MenuItems.Add(delete);
                menu.Show(listViewCars, new Point(e.X, e.Y));
            }
        }

        private void listViewCars_DeleteItem(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void listViewCars_EditItem(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
