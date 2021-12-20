using Keeper.Models;
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

namespace Keeper.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageOrderProduct.xaml
    /// </summary>
    public partial class PageOrderProduct : Page
    {
        private int orderID = -1;
        public PageOrderProduct(int id)
        {
            InitializeComponent();
            orderID = id;
            Update();
            Update_Categoty();
        }
        public void Update()
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var order_prod = db.OrderAndItems.ToArray();
                var reresult = from u in order_prod
                               where u.OrderId == orderID
                               select u;
                ListViewOrderProduct.ItemsSource = reresult;
                var ord = db.Orders.ToArray();
                var res = from u in ord
                          where u.OrderId == orderID
                          select u;
                if (res.FirstOrDefault().Status == "Завершён")
                    ListViewCategory.IsEnabled = false;
            }
        }
        public void Update_Categoty()
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var categ = db.Categories.ToArray();
                ListViewCategory.ItemsSource = categ;
            }
        }

        private void BackToCategory_Click(object sender, RoutedEventArgs e)
        {
            ListViewCategory.Visibility = Visibility.Visible;
            ListViewProduct.Visibility = Visibility.Collapsed;
        }

        private void ListViewCategory_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                ListViewProduct.ItemsSource = null;
                if (ListViewCategory.SelectedIndex == -1)
                    return;
                Category selected = (Category)ListViewCategory.SelectedItem;
                var users = db.Categories.ToArray();
                var reresult = from u in users
                               where u.CategoryId == selected.CategoryId
                               select u;
                foreach (Category t in reresult)
                {
                    var prod = db.Products.ToArray();
                    var res = from u in prod
                              where u.CategoryId == t.CategoryId
                              select u;
                    ListViewProduct.ItemsSource = res;
                    ListViewCategory.Visibility = Visibility.Collapsed;
                    ListViewProduct.Visibility = Visibility.Visible;
                }
            }
        }

        private void BackToOrder_Click(object sender, RoutedEventArgs e)
        {
            PageOrder page = new PageOrder();
            NavigationService.Navigate(page);
        }

        private void ListViewProduct_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                if (ListViewProduct.SelectedIndex == -1)
                    return;
                Product selected = (Product)ListViewProduct.SelectedItem;
                var prods = db.Products.ToArray();
                var reresult = from u in prods
                               where u.ProductId == selected.ProductId
                               select u;
                var ordProd = db.OrderAndItems.ToArray();
                var res = from u in ordProd
                          where u.ProductId == selected.ProductId && u.OrderId == orderID
                          select u;
                if (res.Count() != 0)
                    res.First().Qty += 1;
                else
                {
                    OrderAndItem orderAndItem = new OrderAndItem
                    {
                        OrderId = orderID,
                        ProductId = reresult.First().ProductId,
                        Qty = 1
                    };
                    db.OrderAndItems.Add(orderAndItem);
                }
                db.SaveChanges();
                Update();
            }
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                if (ListViewOrderProduct.SelectedIndex == -1)
                    return;
                OrderAndItem selected = (OrderAndItem)ListViewOrderProduct.SelectedItem;
                var orderAndItems = db.OrderAndItems.ToArray();
                var result = from u in orderAndItems
                             where u.ProductId == selected.ProductId
                             select u;
                foreach (OrderAndItem t in result)
                {
                    db.OrderAndItems.Remove(t);
                }
                db.SaveChanges();
                Update();
            }
        }
    }
}
