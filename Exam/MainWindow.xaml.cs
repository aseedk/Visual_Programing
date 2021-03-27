using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (Random.IsEnabled)
            {
                var rng = new Random();
                var firstImage = rng.Next(1, 15);
                var secondImage = rng.Next(1, 15);
                var thirdImage = rng.Next(1, 15);
                Image1.Source = new BitmapImage(new Uri(@"\img\"+ firstImage + ".jpg" ));
                Image2.Source = new BitmapImage(new Uri(@"\img\"+ secondImage + ".jpg" ));
                Image3.Source = new BitmapImage(new Uri(@"\img\"+ thirdImage + ".jpg" ));
            }

            else if (Sequential.IsEnabled)
            {
                var picture = Image1.Source.ToString();
                var index = Int32.Parse(picture[0].ToString());
                Image1.Source = new BitmapImage(new Uri(@"\img\"+ ++index + ".png" ));
                Image2.Source = new BitmapImage(new Uri(@"\img\"+ ++index + ".png" ));
                Image3.Source = new BitmapImage(new Uri(@"\img\"+ ++index + ".png" ));
            }
            else
            {
                MessageBox.Show("Incorrect ");
            }
        }
    }
}