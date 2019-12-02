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
using System.Windows.Shapes;
using System.IO;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for Finance.xaml
    /// </summary>
    public partial class Finance : Window
    {
        public Finance()
        {
            InitializeComponent();
        }

        //Back Button
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Updates finance box with new requests
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            string line;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            //Takes information from the file
            var file = new System.IO.StreamReader(projectDirectory + "..\\..\\Data\\Finances.txt");
            while ((line = file.ReadLine()) != null)
            {
                ListFinances.Items.Add(line);
            }
        }

        //Approves the finance request, then removes it from list 
        private void btnApprove_Click(object sender, RoutedEventArgs e)
        {
            while (ListFinances.SelectedItems.Count > 0)
            {
                ListFinances.Items.Remove(ListFinances.SelectedItems[0]);
                try { Console.WriteLine(ListFinances.SelectedIndex); }
                catch { MessageBox.Show("error, file not sent"); }
                
            }
        }

        //Removes the finance request, then removes it form list
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            while (ListFinances.SelectedItems.Count > 0)
            {
                ListFinances.Items.Remove(ListFinances.SelectedItems[0]);
            }
        }
    }
}
