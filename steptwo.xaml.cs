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
    /// Interaction logic for steptwo.xaml
    /// </summary>
    public partial class steptwo : Window
    {
        public steptwo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stepthree stt = new stepthree();
            stt.Show();
            this.Close();
        }

        private void Label99_MouseEnter(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lcc.edu.ph/wp-content/uploads/2022/06/LCCB-Payment-Options.pdf");
        }
    }
}
