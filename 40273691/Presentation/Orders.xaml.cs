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
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Refreshes data with latest order information
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            bool orderInfo = false;
            bool infolist = false;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            string line;
            var file = new System.IO.StreamReader(projectDirectory + "..\\..\\Data\\Orders.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (orderInfo == false) {
                    listOrders.Items.Add(line);
                    orderInfo = true;
                }
                else if (infolist == false)
                {
                    listInfo.Items.Add(line);
                    infolist = true;
                }
                else
                {
                    listStatus.Items.Add(line);
                    infolist = false;
                    orderInfo = false;
                }
            }
        }

        private void BtnCancle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnComplete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUp_Click(object sender, RoutedEventArgs e)
        {
            if (listInfo.SelectedItem == null || listInfo.SelectedIndex < 0)
                return; // No selected item - nothing to do

            object selected = listInfo.SelectedItem;

            int newIndex = listInfo.SelectedIndex - 1;

            if (newIndex < 0 || newIndex >= listInfo.Items.Count)
                return; // Index out of range - nothing to do

            listInfo.Items.Remove(selected);
            listInfo.Items.Insert(newIndex, selected);

        }

        private void BtnDown_Click(object sender, RoutedEventArgs e)
        {
            if (listInfo.SelectedItem == null || listInfo.SelectedIndex < 0)
                return; // No selected item - nothing to do


            object selected = listInfo.SelectedItem;


            int newIndex = listInfo.SelectedIndex + 1;

            if (newIndex < 0 || newIndex >= listInfo.Items.Count)
                return; // Index out of range - nothing to do

            listInfo.Items.Remove(selected);
            listInfo.Items.Insert(newIndex, selected);

        }
    }
}
