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
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Atlantic",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Atlantic_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Atlantic_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Atlantic_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Atlantic_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Atlantic_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }
        public void FillCentral()
        {
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Central",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Central_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Central_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Central_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Central_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Central_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }
        public void FillSoutheast()
        {
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Southeast",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Southeast_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Southeast_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Southeast_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Southeast_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Southeast_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }
        public void FillNorthwest()
        {
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Northwest",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Northwest_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Northwest_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Northwest_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Northwest_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Northwest_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }
        public void FillPacific()
        {
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Pacific",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Pacific_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Pacific_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Pacific_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Pacific_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Pacific_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }
        public void FillSouthwest()
        {
            TextBox tb = new TextBox()
            {
                TextWrapping = TextWrapping.Wrap,
                Text = "Southwest",
                VerticalAlignment = VerticalAlignment.Top,
                IsEnabled = false,
                Background = new SolidColorBrush(Colors.LightGray),
                FontSize = 14,
                HorizontalContentAlignment = HorizontalAlignment.Center,
                VerticalContentAlignment = VerticalAlignment.Center,
            };
            Southwest_Grid.Children.Add(tb);
            Grid.SetRow(tb, 0);
            for (int i = 0; i < 5; i++)
            {
                RowDefinition row = new RowDefinition()
                {
                    Height = new GridLength(80),
                };
                Southwest_Grid.RowDefinitions.Add(row);
                Rectangle rct = new Rectangle()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    Height = 80,
                    Stroke = new SolidColorBrush(Colors.Gray),
                    VerticalAlignment = VerticalAlignment.Top,
                    Width = 342,
                    StrokeThickness = 2,
                };
                BitmapImage bitmap = new BitmapImage();
                bitmap.UriSource = new Uri("pack://application:,,,/Teams/1.jpg");
                System.Windows.Controls.Image img = new System.Windows.Controls.Image()
                {
                    HorizontalAlignment = HorizontalAlignment.Left,
                    Height = 66,
                    Width = 66,
                    VerticalAlignment = VerticalAlignment.Top,
                    Source = bitmap,
                    Margin = new Thickness(10, 0, 0, 0)
                };
                Label lb = new Label()
                {
                    Content = teams[j].Name,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalAlignment = VerticalAlignment.Top,
                    IsEnabled = false,
                    Width = 250,
                    Margin = new Thickness(81, 7, 0, 0)
                };
                j++;

                Southwest_Grid.Children.Add(lb);
                Grid.SetRow(lb, i + 1);
                Southwest_Grid.Children.Add(img);
                Grid.SetRow(img, i + 1);
                Southwest_Grid.Children.Add(rct);
                Grid.SetRow(rct, i + 1);
            }
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            VisitorMain win = new VisitorMain();
            win.Show();
            this.Close();
        }
    }

}
