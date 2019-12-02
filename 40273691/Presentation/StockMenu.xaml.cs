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
    /// Interaction logic for StockChanges.xaml
    /// </summary>
    public partial class StockChanges : Window
    {
        public StockChanges()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnQuantity_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ChangeStock Window = new ChangeStock();
            Window.ShowDialog();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            NewStock Window = new NewStock();
            Window.ShowDialog();
        }
    }
}
