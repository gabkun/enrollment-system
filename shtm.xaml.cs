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
    /// Interaction logic for shtm.xaml
    /// </summary>
    public partial class shtm : Window
    {
        public shtm()
        {
            InitializeComponent();
        }

        private void Button23_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lcc.edu.ph/requirements/");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            courses cs = new courses();
            cs.Show();
            this.Close();
        }
    }
}
