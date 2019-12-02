using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Business_Objects
{
    public class Stock
    {
        //Initalise variables
        private String stockItem;
        private String stockQuantity;
        private String stockPrice;
        public int id;
        public static int idCount = 1;

        private bool anyError = false;
        
        //Set up stock type/ name
        public String StockItem
        {
            get
            {
                return stockItem;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid Stock Name");
                    }
                    stockItem = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        //Set up stock quantity
        public String StockQuantity
        {
            get
            {
                return stockQuantity;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid Quantity");
                    }
                    stockQuantity = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        //Set up Stock Price
        public String StockPrice
        {
            get
            {
                return stockPrice;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid Price");
                    }
                    stockPrice = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        //ID set up
        public int IDNo
        {
            get
            {
                return id;
            }
            set
            {
                try
                {
                    if (value < 1)
                    {
                        anyError = true;
                        throw new ArgumentException("Invalid ID");
                    }
                    id = value;
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        //Moves ID to next number in the list
        public void refNoIncrement()
        {
            idCount++;
        }

        //ID counter
        public int refNoCounter
        {
            get
            {
                return idCount;
            }
        }

    }
}
