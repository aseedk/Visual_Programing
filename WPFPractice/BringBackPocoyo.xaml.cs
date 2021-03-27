using System.Windows;
using System.Windows.Controls;

namespace WPFPractice
{
    public partial class BringBackPocoyo : Window
    {
        public BringBackPocoyo()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First Image Clicked");
        }
        
        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Second Image Clicked");
        }
        
        private void ButtonBase_OnClick3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Third Image Clicked");
        }
    }
}