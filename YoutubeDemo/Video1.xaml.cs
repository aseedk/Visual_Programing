using System.Windows;

namespace YoutubeDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Video1: Window
    {
        public Video1()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your Name is :" + Name.Text);
        }
    }
}