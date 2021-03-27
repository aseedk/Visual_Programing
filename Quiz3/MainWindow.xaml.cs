using System;
using System.Windows;
using System.Windows.Input;

namespace Quiz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ExitCommandContext();
        }
        public class ExitKey: ICommand
        {
            public void Execute(object parameter)
            {
                Application.Current.Shutdown();
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }
        public class WrapKey: ICommand
        {
            public void Execute(object parameter)
            {
                MessageBox.Show("Wrap Shortcut Key Pressed");
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        ((MainWindow) window).TextBoxItem.TextWrapping = ((MainWindow) window).TextBoxItem.TextWrapping == TextWrapping.NoWrap ? TextWrapping.Wrap : TextWrapping.NoWrap;
                    }
                }
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }
        public class TimeKey: ICommand
        {
            public void Execute(object parameter)
            {
                MessageBox.Show("Wrap Shortcut Key Pressed");
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        ((MainWindow) window).TextBoxItem.Text += DateTime.Now;
                    }
                }
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;
        }
        public class ExitCommandContext
        {
            public ICommand ExitCommand => new ExitKey();
            public ICommand WrapCommand => new WrapKey();
            public ICommand TimeCommand => new TimeKey();
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void New_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void New_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Menu Item: New");
        }

        private void Open_OnCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Open_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New Menu Item: Open");
        }

        private void Time(object sender, RoutedEventArgs e)
        {
            TextBoxItem.Text += DateTime.Now.ToString();
        }
    }
}