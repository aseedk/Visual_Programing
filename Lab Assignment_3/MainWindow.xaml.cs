using System;
using System.IO;
using System.Windows;
using System.Xml;

namespace Lab_Assignment_3
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

        private string GetXml()
        {
            var xmlDisplayString = "";
            XmlReader xmlReader = null;
            try
            {
                xmlReader = new XmlTextReader(XmlPath.Text);
            }
            catch (FileNotFoundException)
            {
                XmlDisplay.Text = "File Not Found ";
            }
            catch (IOException)
            {
                XmlDisplay.Text = "File Not Found";
            }
            catch (XmlException)
            {
                XmlDisplay.Text = "File Not Found";
            }
            catch (Exception e)
            {
                XmlDisplay.Text = e.Message;
            }

            while (xmlReader != null && xmlReader.Read()) {
                switch (xmlReader.NodeType) {
                    case XmlNodeType.Element:
                        if (ElementCheck.IsChecked == true)
                        {
                            xmlDisplayString += "<" + xmlReader.Name;
                            if (AttributeCheck.IsChecked == true)
                            {
                                for (var i = 0; i < xmlReader.AttributeCount; i++) {
                                    xmlReader.MoveToAttribute(i);
                                    xmlDisplayString += " " + xmlReader.Name + "=" + xmlReader.Value;
                                }
                            }
                            xmlDisplayString += ">\n";
                        }
                        break;
                    case XmlNodeType.Text:
                        if (TextCheck.IsChecked == true)
                        {
                            xmlDisplayString += xmlReader.Value + "\n";
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (EndElementCheck.IsChecked == true)
                        {
                            xmlDisplayString += "</" + xmlReader.Name;
                            if (AttributeCheck.IsChecked == true)
                            {
                                for (var i = 0; i < xmlReader.AttributeCount; i++) {
                                    xmlReader.MoveToAttribute(i);
                                    xmlDisplayString += " " + xmlReader.Name + "=" + xmlReader.Value;
                                }
                            }
                            xmlDisplayString += ">\n";
                        }
                        break;
                    case XmlNodeType.None:
                        break;
                    case XmlNodeType.Attribute:
                        break;
                    case XmlNodeType.CDATA:
                        break;
                    case XmlNodeType.EntityReference:
                        break;
                    case XmlNodeType.Entity:
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        break;
                    case XmlNodeType.Comment:
                        break;
                    case XmlNodeType.Document:
                        break;
                    case XmlNodeType.DocumentType:
                        break;
                    case XmlNodeType.DocumentFragment:
                        break;
                    case XmlNodeType.Notation:
                        break;
                    case XmlNodeType.Whitespace:
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        break;
                    case XmlNodeType.EndEntity:
                        break;
                    case XmlNodeType.XmlDeclaration:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return xmlDisplayString;
        }

        private void XmlPrint(object sender, RoutedEventArgs e)
        {
            XmlDisplay.Text = GetXml();
        }
    }
}