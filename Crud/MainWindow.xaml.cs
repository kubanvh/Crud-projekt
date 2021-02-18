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
using System.Data.SqlClient;
using System.Data;

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
        //ProductTb NewProduct = new ProductTb();
        //ProductTb selectedProduct = new ProductTb();

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
            //var productToDelete = (sender as FrameworkElement).DataContext as ProductTb;
            //contex.ProductTb.Remove(productToDelete);
            //contex.SaveChanges();

            //foreach(var prod in contex.ProductTb)
            //{
            //   if(prod.ProductID == prod.ProductID)
            //    {
            //        add_productId.Items.Add($)
            //    }
            //}
        }
        private void UpdateProductHandler(object sender, System.EventArgs e)
        {
            //selectedProduct = (sender as FrameworkElement).DataContext as ProductTb;
            //productTbDataGrid.DataContext = selectedProduct;
            //ProductTb newProductTb = new ProductTb()
            //{
            //    Brand = add_productBrand.Text,
            //    Category = add_productCategory.Text,
            //    ProductID = int.Parse(add_productId.Text),
            //    ProductName = add_productName.Text,
            //    Price = decimal.Parse(add_productPrice.Text)
            //};
            //int len = contex.CustomerTb.Local.Count();
            //int pos = len;
            //for(int i = 0; i<len; ++i)
            //{

            //}
        }
        private void AddProductHandler(object sender, System.EventArgs e)
        {
            //contex.ProductTb.Add(NewProduct);
            //contex.SaveChanges();
            //NewProduct = new ProductTb();
            //newProductGrid.DataContext = NewProduct;

        }
        private void CancelProductHandler(object sender, System.EventArgs e)
        {
            add_productBrand.Text = "";
            add_productCategory.Text = "";
            add_productId.Text = "";
            add_productName.Text = "";
            add_productPrice.Text = "";
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection sqlCon1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog = crudDb; Integrated Security=true;");
                if (sqlCon1.State == ConnectionState.Closed)
                    sqlCon1.Open();
                string query = "INSERT INTO ProductTb(ProductID, ProductName, Brand, Category, Price) values('" + this.add_productId.Text + "','" + this.add_productName.Text + "','" + this.add_productBrand.Text + "','" + this.add_productCategory.Text + "','" + this.add_productPrice.Text + "');";
                SqlCommand sqlCmd1 = new SqlCommand(query, sqlCon1);
                SqlDataReader sqlDataReader1;
                sqlDataReader1 = sqlCmd1.ExecuteReader();
                MessageBox.Show("Product added to database");
                while (sqlDataReader1.Read())
                {
                }
                sqlCon1.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

//        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
//        {
            //var prod = productViewSource.View.CurrentItem as ProductTb;
            //if(prod == null)
            //{
            //    MessageBox.Show("No product selected.");
            //    return;
            //}
            //newProductGrid.UpdateLayout();

//        }


//        private void btnUpdate_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnCancel_Click(object sender, RoutedEventArgs e)
//        {

//        }

//        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
//        {

//        }
//        private void AUD(String sql_stmt, int state)
//        {
//            String msg = "";
//            OracleCommand cmd = con.CreateCommand();
//            cmd.CommandText = sql_stmt;
//            cmd.CommandType = CommandType.Text;
//        }
//            switch(State)
//                {
//                case 0;
//                break;
//                case 1;
//                break;
//                case 2;
//                break;
//        }
//}
//}
