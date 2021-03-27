using System.Windows;
using System.Windows.Controls;

namespace YoutubeDemo
{
    public partial class Video2 : Window
    {
        public Video2()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var number1 = int.TryParse(Number1.Text, out var num1);
            var number2 = int.TryParse(Number2.Text, out var num2);
            if (number1 != true || number2 != true) return;
            if (button != null && button.Content.ToString() == "+")
            {
                Answer.Content = num1 + num2;
            }else if (button != null && button.Content.ToString() == "-")
            {
                Answer.Content = num1 - num2;
            }

        }
    }
}