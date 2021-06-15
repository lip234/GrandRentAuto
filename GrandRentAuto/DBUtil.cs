using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GrandRentAuto
{
    class DBUtil
    {
        private static SqlConnection conn;
        public static void Close()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connString = Properties.Settings.Default.ConnectionString;
                conn = new SqlConnection(connString);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static void PopulateListView(SqlDataReader reader, ListView view)
        {
            view.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = reader[0].ToString();
                for(int i=1; i<reader.FieldCount; i++)
                {
                    item.SubItems.Add(reader[i].ToString());
                }
                view.Items.Add(item);
            }
        }
        public static void PopulateCombobox(SqlDataReader reader, ComboBox box)
        {
            PopulateCombobox(reader, box, true);
        }
        public static void PopulateCombobox(SqlDataReader reader, ComboBox box, bool clearItems)
        {
            if (clearItems)
            {
                box.Items.Clear();
            }
            while (reader.Read())
            {
                box.Items.Add(reader[0].ToString());
            }
        }
        public static void PopulateComboxBoxSQL(string sql, ComboBox box)
        {
            PopulateComboxBoxSQL(sql, box, true);
        }

        public static void PopulateComboxBoxSQL(string sql, ComboBox box, bool clearItems)
        {

            using (SqlCommand cmd = new SqlCommand(sql, DBUtil.GetConnection()))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    PopulateCombobox(reader, box, clearItems);
                }
            }
        }        
        

    }
}
