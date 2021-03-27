
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Lab_Sessional_1
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
            if (random.IsEnabled)
            {
                var rng = new Random();
                var FirstImage = rng.Next(1, 15);
                var SecondImage = rng.Next(1, 15);
                var ThirdImage = rng.Next(1, 15);
                Image1.Source = new BitmapImage(new Uri(@"\img\"+ FirstImage + ".jpg" ));
                Image2.Source = new BitmapImage(new Uri(@"\img\"+ SecondImage + ".jpg" ));
                Image3.Source = new BitmapImage(new Uri(@"\img\"+ ThirdImage + ".jpg" ));
            }

            else if (sequential.IsEnabled)
            {
                var picture = Image1.Source.ToString();
                var index = Int32.Parse(picture[0].ToString());
                Image1.Source = new BitmapImage(new Uri(@"\img\"+ index + ".png" ));
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