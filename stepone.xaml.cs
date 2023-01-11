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
    /// Interaction logic for stepone.xaml
    /// </summary>
    public partial class stepone : Window
    {
        public stepone()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            steptwo st = new steptwo();
            st.Show();
            this.Close();
        }

        private void Button15_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lcc.schoolautomate.com/PARENTS_STUDENTS/parents_student_index.jsp");
        }

        private void Button16_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lcc.edu.ph/appointments");
        }

        private void Button17_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lcc.edu.ph/appointments");
        }
    }
}
