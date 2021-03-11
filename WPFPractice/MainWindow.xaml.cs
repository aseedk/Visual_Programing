using System.Windows;
using System.Windows.Controls;

namespace WPFPractice
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
            var button = sender as Button;
            var num1 = int.Parse(TxtFirst.Text);
            var num2 = int.Parse(TxtSecond.Text);
            if (button != null && button.Content.Equals("Sum"))
            {
                var output = num1 + num2;
                TxtOutput.Text = "Output: " + output;
            }
            else
            {
                var output = num1 - num2;
                TxtOutput.Text = "Output: " + output;
            }
            
        }
        
    }
}