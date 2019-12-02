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
using System.Text;



namespace Presentation
{
    /// <summary>
    /// Interaction logic for Loyalty.xaml
    /// </summary>
    public partial class Loyalty : Window
    {
        public Loyalty()
        {
            InitializeComponent();
            bool offerInfo = false;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            string line;
            var file = new System.IO.StreamReader(projectDirectory + "..\\..\\Data\\LoyaltyCodes.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (offerInfo == false)
                {
                    offerList.Items.Add(line);
                    offerInfo = true;
                }
                else
                {
                    offerList.Items.Add(line);
                    offerInfo = false;
                }
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Adds new offer to list
        private void btnRule_Click(object sender, RoutedEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            if (String.IsNullOrEmpty(txtOffer.Text))
            {
                MessageBox.Show("Please enter an offer to be added");
            }
            else
            {
                offerList.Items.Add(txtOffer.Text);
                MessageBox.Show("Offer added");
                //Taskes the offer input, saves it out to persist (Not included due to unable to remove)
                string text = File.ReadAllText(projectDirectory + "..\\..\\Data\\LoyaltyCodes.txt");
                string createText = txtOffer.Text;
                text = text + createText;
               // File.WriteAllText(projectDirectory + "..\\..\\Data\\LoyaltyCodes.txt", text);
                txtOffer.Text = null;
            }

        }

        //Removes offer from list
        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (offerList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an offer to be removed");
            }
            else
            {
                offerList.Items.Remove(offerList.SelectedItem);
                MessageBox.Show("Offer removed");
                txtOffer.Text = null;
            }
        }
    }
}
