using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace MailingList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "Text Files (*.txt) | *.txt | All Files (*.*) | *.*";

            if (openFileDialog.ShowDialog() == true)
            {
                tblResult.Text = File.ReadAllText(openFileDialog.FileName);
            }   
        }
        private void ParseList(string s)
        {
            string[] delimiters = new string[] { "<", ">;" };
            string[] parts = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string joinedText;
            joinedText = string.Join("  ", parts);
            MessageBox.Show(joinedText);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ParseList(tblResult.Text);
        }
    }
}
