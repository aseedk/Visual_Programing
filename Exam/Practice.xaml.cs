using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Practice
    {
        private BitmapImage[] Images = new[]
        {
            new BitmapImage(new Uri("/img/1.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/2.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/3.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/4.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/5.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/6.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/7.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/8.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/9.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/10.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/11.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/12.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/13.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/14.jpg", UriKind.Relative)),
            new BitmapImage(new Uri("/img/15.jpg", UriKind.Relative))
        };

        private int sequential;
        public Practice()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (Random.IsChecked == true)
            {
                var rng = new Random();
                var firstImage = rng.Next(1, 15);
                var secondImage = rng.Next(1, 15);
                var thirdImage = rng.Next(1, 15);
                Image1.Source = Images[firstImage];
                Image2.Source = Images[secondImage];
                Image3.Source = Images[thirdImage];
            }
            else if (Sequential.IsChecked == true)
            {
                if (sequential == 15)
                {
                    sequential = 0;
                }
                Image1.Source = Images[sequential++];
                Image2.Source = Images[sequential++];
                Image3.Source = Images[sequential++];
                MessageBox.Show(sequential + "");
            }
        }
    }
}