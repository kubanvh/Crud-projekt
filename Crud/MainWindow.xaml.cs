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
using System.Data.Entity;

namespace Crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        crudDbEntities contex = new crudDbEntities();
        CollectionViewSource productViewSource;
        //CollectionViewSource ordersViewSource;
        //CollectionViewSource productViewSource;
        public MainWindow()
        {
            InitializeComponent();
            productViewSource = ((CollectionViewSource)(FindResource("productTbViewSource")));
            //orderProductViewSource = ((CollectionViewSource)(FindResource("orderProductTbViewSource")));
            //ordersViewSource = ((CollectionViewSource)(FindResource("ordersTbViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            contex.ProductTb.Load();
            productViewSource.Source = contex.ProductTb.Local;

        }
        private void DeleteProductHandler(object sender, System.EventArgs e)
          {

        }
        private void UpdateProductHandler(object sender, System.EventArgs e)
        {

        }
        private void AddProductHandler(object sender, System.EventArgs e)
        {

        }
        private void CancelProductHandler(object sender, System.EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
