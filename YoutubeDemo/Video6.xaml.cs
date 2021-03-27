using System;
using System.Windows;
using System.Windows.Input;

namespace YoutubeDemo
{
    public partial class Video6 : Window
    {
        public Video6()
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
                    if (window.GetType() == typeof(Video6))
                    {
                        ((Video6) window).TextBox.TextWrapping = ((Video6) window).TextBox.TextWrapping == TextWrapping.NoWrap ? TextWrapping.Wrap : TextWrapping.NoWrap;
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
            public object objForWrap;
            public ICommand ExitCommand => new ExitKey();
            public ICommand WrapCommand => new WrapKey();
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
    }
}