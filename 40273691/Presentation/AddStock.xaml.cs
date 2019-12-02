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

    public partial class NewStock : Window
    {
        //Starts list for stock
        private StockList stockstore = StockList.getCurrent();
        public NewStock()
        {
            InitializeComponent();
            dealList.Items.Add("3 for 2");
            dealList.Items.Add("Buy one get one free");
            dealList.Items.Add("Free delivery");
        }

        //Back Button
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            StockChanges Window = new StockChanges();
            Window.ShowDialog();
        }

        //Updates stored list with new stock
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int num;
            Stock aStock = new Stock();
            //Validation
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Error, please enter data");
            }
            else if(!int.TryParse(txtQuantity.Text, out num))
            {
                MessageBox.Show("Error, please ensure quanitity is numerical");
            }
            else if (!int.TryParse(txtPrice.Text, out num))
            {
                MessageBox.Show("Error, please ensure price is numerical");
            }
            else
            //Adds current information to the list
            {
                aStock.StockItem = txtName.Text;
                aStock.StockQuantity = txtQuantity.Text;
                aStock.StockPrice = txtPrice.Text;
                aStock.IDNo = aStock.refNoCounter;
                aStock.refNoIncrement();
                stockstore.add(aStock);

                //Completion message
                MessageBox.Show("Stock added, reference: " + aStock.IDNo);

                this.Close();
                StockChanges Window = new StockChanges();
                Window.ShowDialog();
            }
        }
    }
}
