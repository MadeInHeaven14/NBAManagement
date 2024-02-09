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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Windows.Controls.Image;

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void btn_Visitor_Click(object sender, RoutedEventArgs e)
        {
            VisitorMain win = new VisitorMain();
            win.Show();
            this.Close();
        }

        private void ImageSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpdateImages();
        }

        private void UpdateImages()
        {
            List<string> Images = new List<string>();
            Images.Add("Img/Pictures/1.jpg");
            Images.Add("Img/Pictures/2.jpg");
            Images.Add("Img/Pictures/3.jpg");
            Images.Add("Img/Pictures/4.jpg");
            Images.Add("Img/Pictures/5.jpg");
            Images.Add("Img/Pictures/8.jpg");
            Images.Add("Img/Pictures/9.jpg");
            Images.Add("Img/Pictures/10.jpg");
            Images.Add("Img/Pictures/11.jpg");
            Images.Add("Img/Pictures/12.jpg");
            Images.Add("Img/Pictures/15.jpg");
            Images.Add("Img/Pictures/16.jpg");
            Images.Add("Img/Pictures/17.jpg");
            Images.Add("Img/Pictures/18.jpg");
            ImageWrapPanel.Children.Clear();

            // Получаем текущее значение Slider
            int sliderValue = (int)ImageSlider.Value;

            // Загружаем изображения
            for (int i = sliderValue; i < sliderValue + 3 && i < Images.Count; i++)
            {
                Image image = new Image();
                image.Source = new BitmapImage(new Uri(Images[i], UriKind.Relative));
                image.Width = 200; // Ширина изображения
                image.Height = 200; // Высота изображения
                if (i > sliderValue)
                {
                    image.Margin = new Thickness(100, 0, 0, 0); // Отступ слева между изображениями
                }
                ImageWrapPanel.Children.Add(image);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateImages();
        }
    }
}
