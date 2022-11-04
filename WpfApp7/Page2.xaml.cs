using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.IO;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
            
        }
        private void save_bt(object sender, RoutedEventArgs e)
        {
            try
            {
                string _name_in = name_in.Text;
                string _bname_in = bname_in.Text;
                string _fname_in = fname_in.Text;
                string _mname_in = mname_in.Text;
                string _dob_in = dob_in.Text;
                string _nid_no_in = nid_no_in.Text;
                string _b_h__in = b_h__in.Text;

                if (_name_in != "" || _bname_in != "" || _fname_in != "" || _mname_in!="" || _dob_in != "" || _name_in != "" || _b_h__in !="")
                {
                    using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\kader\MyDatabase7.db;"))
                    {
                        conn.Open();
                        string sql1 = "INSERT INTO NID_Service (E_name, B_name, F_name, M_name, dob, nid_no, basha_holding) VALUES('" + _name_in + "','" + _bname_in + "','" + _fname_in + "','" + _mname_in + "','" + _dob_in + "','" + _nid_no_in + "','" + _b_h__in + "')";
                        SQLiteCommand cmd = new SQLiteCommand(sql1, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Information is Save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void updae_bt(object sender, RoutedEventArgs e)
        {

        }

        private void delete_bt(object sender, RoutedEventArgs e)
        {

        }
    }
}
