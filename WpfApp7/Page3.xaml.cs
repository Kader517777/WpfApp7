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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            
        }

        private void nid_search(object sender, RoutedEventArgs e)
        {
            try
            {
                
                

                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\kader\MyDatabase7.db;"))
                {
                    conn.Open();
                    string sql1 = "SELECT * FROM [NID_Service] WHERE nid_no= '" + search.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql1,conn);
                    SQLiteDataReader qLiteDataReader = cmd.ExecuteReader();
                    while (qLiteDataReader.Read())
                    {
                        name_in.Text = qLiteDataReader["E_name"].ToString();
                        bname_in.Text = qLiteDataReader["B_name"].ToString();
                        fname_in.Text = qLiteDataReader["F_name"].ToString();
                        mname_in.Text = qLiteDataReader["M_name"].ToString();
                        //b_h__in.Text = qLiteDataReader["dob"].ToString() ;
                        nid_no_in.Text = qLiteDataReader["nid_no"].ToString();
                        b_h__in.Text = qLiteDataReader["basha_holding"].ToString();
                        //g_r_in.Text = qLiteDataReader["E_name"].ToString();
                        //blood_in.Text = qLiteDataReader["E_name"].ToString();
                        //blood_in.Text = qLiteDataReader["E_name"].ToString();

                        
                    }
                    

                    conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
