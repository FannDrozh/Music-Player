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

namespace Music_Player
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Entre : Window
    {
        public Entre()
        {
            InitializeComponent();
        }

        private void Exit_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Entree_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NotAc_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //Entre entre = new Entre();
            //entre.Close();
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
            
        }
    }
}
