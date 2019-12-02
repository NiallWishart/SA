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

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Main menu, used to navigate the whole program
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFinance_Click(object sender, RoutedEventArgs e)
        {
            Finance Window = new Presentation.Finance();
            Window.ShowDialog();
        }

        private void btnLogs_Click(object sender, RoutedEventArgs e)
        {
            Orders Window = new Presentation.Orders();
            Window.ShowDialog();
        }

        private void btnLoyal_Click(object sender, RoutedEventArgs e)
        {
            Loyalty Window = new Presentation.Loyalty();
            Window.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StockChanges Window = new Presentation.StockChanges();
            Window.ShowDialog();
        }
    }
}
