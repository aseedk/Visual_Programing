using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Quiz_3
{
    public partial class MainWindow : Window
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
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        ((MainWindow) window).TextBox.TextWrapping = ((MainWindow) window).TextBox.TextWrapping == TextWrapping.NoWrap ? TextWrapping.Wrap : TextWrapping.NoWrap;
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
                        ((MainWindow) window).TextBox.Text += DateTime.Now;
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
        private void Time(object sender, RoutedEventArgs e)
        {
            TextBox.Text += DateTime.Now.ToString();
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
    }
}