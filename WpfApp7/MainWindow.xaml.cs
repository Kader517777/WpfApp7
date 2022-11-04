using System;
using Microsoft.Win32;
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
using System.Data.SqlClient;
using System.Diagnostics;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Class1 class1 = new Class1();
            class1.f_C_bt();
            class1.d_C_bt();
            class1.t_C_bt();

        }

        private void home_bt(object sender, RoutedEventArgs e)
        {
            main.Content = new Page1();
        }

        private void nid_info_bt(object sender, RoutedEventArgs e)
        {
            main.Content = new Page2();
        }

        private void nid_search_bt(object sender, RoutedEventArgs e)
        {
            main.Content = new Page3();
        }

        private void name_search_bt(object sender, RoutedEventArgs e)
        {
            main.Content = new Page4();
        }
    }
}

