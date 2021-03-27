using System;
using System.Windows;
using System.Windows.Controls;

namespace YoutubeDemo
{
    public partial class Video3 : Window
    {
        public Video3()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            if (CityComboBox.SelectedIndex >= 0 && CityListBox.SelectedIndex >= 0)
            {
                MessageBox.Show("Selected City is:" + CityComboBox.SelectionBoxItem + "\nSelected City Is: "
                                + ((ListBoxItem) CityListBox.SelectedItem).Content);
            }
        }
    }
}