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
using Business_Objects;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for ChangeStock.xaml
    /// </summary>
    public partial class ChangeStock : Window
    {
        //Variable iniltaise
        private Stock changeStock;
        private StockList stockstore = StockList.getCurrent();
        private int searchStock;

        public ChangeStock()
        {
            InitializeComponent();
        }

        //Back button
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            StockChanges Window = new StockChanges();
            Window.ShowDialog();
        }

        //Takes in ID, sends to Business to search for ID in list, display all details
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            dealList.Items.Clear();
            try { searchStock = Int32.Parse(txtID.Text); }
            catch { MessageBox.Show("invalid ID, please enter a numerical character"); }

            if (stockstore.find(searchStock) != null)
            {
                changeStock = stockstore.find(searchStock);
                txtName.Text = changeStock.StockItem;
                txtPrice.Text = changeStock.StockPrice;
                txtQuantity.Text = changeStock.StockQuantity;
                dealList.Items.Add("3 for 2");
                dealList.Items.Add("Buy one get one free");
                dealList.Items.Add("Free delivery");
            }
            else
            {
                MessageBox.Show("ID not found, please enter a valid ID");
            }
        }

        //Takes data in textboxes, updates current position in list with new data
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    //validation
                    int stockCheck = Convert.ToInt32(txtQuantity.Text);
                    int priceCheck = Convert.ToInt32(txtPrice.Text);


                    changeStock.StockItem = txtName.Text;
                    changeStock.StockPrice = txtPrice.Text;
                    changeStock.StockQuantity = txtQuantity.Text;
                    
                    if (stockCheck > 0 && stockCheck < 10) { MessageBox.Show("Please order more stock, the quantity is low"); }
                    if (stockCheck == 0)
                    {
                        MessageBox.Show("No stock left, automatically ordering minimum stock requirement");
                        changeStock.StockQuantity = "10";
                        Console.WriteLine("Order 10 of " + changeStock.StockItem);
                    }
                    MessageBox.Show("updated");
                
            }
            catch
            {
                //Validation
                MessageBox.Show("error, no changes made. Please ensure Quantity and price are numerical");
            }
        }

        private void TxtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
