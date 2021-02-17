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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource orderProductTbViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderProductTbViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // orderProductTbViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource ordersTbViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersTbViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // ordersTbViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource productTbViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productTbViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // productTbViewSource.Source = [generic data source]
        }
      private void DeleteProductHandler()
          {

        }
     
    }
}
