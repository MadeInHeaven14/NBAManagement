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

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для VisitorMain.xaml
    /// </summary>
    public partial class VisitorMain : Window
    {
        public VisitorMain()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainScreen win = new MainScreen();
            win.Show();
            this.Close();
        }

        private void btn_Teams_Click(object sender, RoutedEventArgs e)
        {
            TeamsMain win = new TeamsMain();
            win.Show();
            this.Close();
        }
    }
}
