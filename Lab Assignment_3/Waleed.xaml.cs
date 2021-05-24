using System;
using System.Windows;
using System.Xml;

namespace Lab_Assignment_3
{
    public partial class Waleed : Window
    {
        public Waleed()
        {
            InitializeComponent();
        }
        private string GetXml()
        {
            string displayString = "";
            XmlReader reader = null;
            try
            {
                reader = new XmlTextReader(Xmlpath.Text);
            }
            catch (Exception e)
            {
                Display.Text = e.Message;
            }

            while (reader != null && reader.Read()) {
                switch (reader.NodeType) {
                    case XmlNodeType.Element:
                        if (CheckBox1.IsChecked == true)
                        {
                            displayString += " < " + reader.Name;
                            for (int i = 0; i < reader.AttributeCount; i++) {
                                    reader.MoveToAttribute(i);
                                    displayString += " " + reader.Name + " = " + reader.Value;
                            }
                            displayString += " >\n ";
                        }
                        break;
                    case XmlNodeType.Text:
                        if (CheckBox2.IsChecked == true)
                        {
                            displayString += reader.Value + " \n ";
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (CheckBox3.IsChecked == true)
                        {
                            displayString += " </ " + reader.Name;
                            for (int i = 0; i < reader.AttributeCount; i++) {
                                    reader.MoveToAttribute(i);
                                    displayString += " " + reader.Name + " = " + reader.Value;
                                
                            }
                            displayString += " >\n ";
                        }
                        break;
                }
            }
            return displayString;
        }
        private void XmlPrint(object sender, RoutedEventArgs e)
        {
            Display.Text = GetXml();
        }
    }
}