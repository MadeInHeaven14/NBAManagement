using NBAManagement.ADO;
using NBAManagement.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Логика взаимодействия для TeamsMain.xaml
    /// </summary>
    public partial class TeamsMain : Window
    {
        int j = 0;
        List<Team> teams = new List<Team>();
        public TeamsMain()
        {
            InitializeComponent();
            foreach (Team t in DBConnection.connection.Team.ToList())
            {
                teams.Add(t);
            }
            FillAtlantic();
            FillCentral();
            FillNorthwest();
            FillPacific();
            FillSoutheast();
            FillSouthwest();
        }

        public void FillAtlantic()
        {
            List<Team> atlanticTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                atlanticTeams.Add(teams[j]);
                j++;
            }
            lv_Atlantic.ItemsSource = atlanticTeams;
        }
        public void FillCentral()
        {
            List<Team> centralTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                centralTeams.Add(teams[j]);
                j++;
            }
            lv_Central.ItemsSource = centralTeams;
        }
        public void FillSoutheast()
        {
            List<Team> southeastTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                southeastTeams.Add(teams[j]);
                j++;
            }
            lv_Southeast.ItemsSource = southeastTeams;
        }
        public void FillNorthwest()
        {
            List<Team> northwestTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                northwestTeams.Add(teams[j]);
                j++;
            }
            lv_Northwest.ItemsSource = northwestTeams;
        }
        public void FillPacific()
        {
            List<Team> pacificTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                pacificTeams.Add(teams[j]);
                j++;
            }
            lv_Pacific.ItemsSource = pacificTeams;
        }
        public void FillSouthwest()
        {
            List<Team> southwestTeams = new List<Team>();
            for (int i = 0; i < 5; i++)
            {
                southwestTeams.Add(teams[j]);
                j++;
            }
            lv_Southwest.ItemsSource = southwestTeams;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            VisitorMain win = new VisitorMain();
            win.Show();
            this.Close();
        }
    }

}
