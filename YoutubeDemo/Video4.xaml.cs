using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace YoutubeDemo
{
    public partial class Video4 : Window
    {
        private readonly List<Contact> _contacts;
        public Video4()
        {
            InitializeComponent();
            _contacts = new List<Contact>()
            {
                new Contact()
                {
                    Image = new BitmapImage(new Uri("/img/PeepoHappy.jpg", UriKind.Relative)),
                    Name = "John",
                    Number = "+923369825022"
                },
                new Contact()
                {
                    Image = new BitmapImage(new Uri("/img/PeepoHappy.jpg", UriKind.Relative)),
                    Name = "David",
                    Number = "+923135321889"
                }
            };
            ListBoxName.ItemsSource = _contacts;
        }

        private void Button(object sender, RoutedEventArgs e)
        {
            foreach (var variable in _contacts)
            {
                MessageBox.Show(variable.ToString());
            }
            ListBoxName.Items.Refresh();   
        }
    }

    public class Contact
    {
        public BitmapImage Image { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public override string ToString()
        {
            return this.Name + " (" + this.Number + ") ";
        }
    }
}