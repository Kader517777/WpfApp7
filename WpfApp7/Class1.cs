using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows;

namespace WpfApp7
{
   internal class Class1
    {
        public void f_C_bt()
        {
            try
            {
                Directory.CreateDirectory(@"C:\kader");

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            
            
        }

        public void d_C_bt()
        {
            try
            {
                SQLiteConnection.CreateFile(@"C:\kader\MyDatabase7.db");

            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public void t_C_bt()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\kader\MyDatabase7.db; Version=3;"))
                {
                    conn.Open();
                    string sql = "CREATE TABLE NID_Service(E_name varchar(30), B_name varchar(30), F_name varchar(30), M_name varchar(30), dob date, nid_no int, basha_holding varchar(30))";
                    SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }
    }
}
