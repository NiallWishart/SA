using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{
    public class StockList
    {
        public static StockList reference;

        //Create list for searching stock
        private List<Stock> listStock = new List<Stock>();

        //Adds current input stock into the stock list
        public void add(Stock newStock)
        {
            listStock.Add(newStock);
        }

        //Goes through the list to find requested stock info, then returns is
        public List<Stock> GetStockList
        {
            get
            {
                return listStock;
            }
        }

        //Changes any data in current part of list
        public List<Stock> SetStockList
        {
            set
            {
                listStock = value;
            }
        }

        //Check the current position in list
        public static StockList getCurrent()
        {
            if (reference == null)
            {
                reference = new StockList();
            }
            return reference;
        }

        //Finds specific stock in list
        public Stock find(int id)
        {
            foreach (Stock p in listStock)
            {
                if (id == p.IDNo)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
