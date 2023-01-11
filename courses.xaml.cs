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
using System.Windows.Shapes;

namespace prototype
{
    /// <summary>
    /// Interaction logic for courses.xaml
    /// </summary>
    public partial class courses : Window
    {
        public courses()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            basiceducation be = new basiceducation();
            be.Show();
            this.Close();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            sarfaid sf = new sarfaid();
            sf.Show();
            this.Close();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            sbit sb = new sbit();
            sb.Show();
            this.Close();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            shtm sh = new shtm();
            sh.Show();
            this.Close();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            sslate ss = new sslate();
            ss.Show();
            this.Close();
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            gradsch gs = new gradsch();
            gs.Show();
            this.Close();
        }

        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            eteeap et = new eteeap();
            et.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button30_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
