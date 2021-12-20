using Keeper.Models;
using Microsoft.Data.SqlClient;
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
    /// Логика взаимодействия для PageOrder.xaml
    /// </summary>
    public partial class PageOrder : Page
    {
        public PageOrder()
        {
            InitializeComponent();
            Update();
        }
        private bool check = false;
        public void Update()
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                //ListViewOrder.Items.Clear();
                var order = db.Orders.ToArray();
                if (check == false)
                {
                    var result = from u in order
                                 where u.Status != "Завершён"
                                 select u;
                    ListViewOrder.ItemsSource = result;
                    return;
                }
                ListViewOrder.ItemsSource = order;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddControl.Visibility = Visibility.Visible;
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var employees = db.Employees.ToArray();
                var reresult = from u in employees
                               where u.PositionId == 1 || u.PositionId == 2 ||
                                    u.PositionId == 3 || u.PositionId == 4
                               select u;
                Emp.ItemsSource = reresult;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddControl.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int tableNum = Convert.ToInt32(NumTable.Text);
            var employ = Emp.SelectedItem;
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var employees = db.Employees.ToArray();
                int employeeID = -1;
                foreach (Employee emp in employees)
                {
                    if (emp.ToString() == employ.ToString())
                    {
                        employeeID = emp.EmployeeId;
                    }
                }
                Order order = new Order
                {
                    Table = tableNum,
                    Time = new TimeSpan(),
                    OrderAmount = 0,
                    EmployeeId = employeeID,
                    Status = ""
                };
                db.Orders.Add(order);
                db.SaveChanges();
                Update();
                PageOrderProduct page = new PageOrderProduct(order.OrderId);
                NavigationService.Navigate(page);
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                if (ListViewOrder.SelectedIndex == -1)
                    return;
                Order selected = (Order)ListViewOrder.SelectedItem;
                var users = db.Orders.ToArray();
                var reresult = from u in users
                               where u.OrderId == selected.OrderId
                               select u;
                foreach (Order t in reresult)
                {
                    db.Orders.Remove(t);
                }
                db.SaveChanges();
                Update();
            }
        }

        private void ListViewOrder_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                if (ListViewOrder.SelectedIndex == -1)
                    return;
                Order selected = (Order)ListViewOrder.SelectedItem;
                var users = db.Orders.ToArray();
                var reresult = from u in users
                               where u.OrderId == selected.OrderId
                               select u;
                foreach (Order t in reresult)
                {
                    PageOrderProduct page = new PageOrderProduct(t.OrderId);
                    NavigationService.Navigate(page);
                }
            }
        }

        private void CheckBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CheckButton.IsChecked == true)
            {
                check = false;
                AllDelete.Visibility = Visibility.Collapsed;
            }
            else
            {
                check = true;
                AllDelete.Visibility = Visibility.Visible;
            }
            Update();
        }

        private void AllDelete_Click(object sender, RoutedEventArgs e)
        {
            WindowDialog windowDialog = new WindowDialog();
            if (windowDialog.ShowDialog() == false)
                return;
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var res = db.Orders.ToArray().Count();
                if (res == 0)
                    return;
            }

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ValeraDB;Integrated Security=True";
            string sqlExpression = "delete_all_order";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var result = command.ExecuteNonQuery();
            }
            Update();
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var revenue = db.RevenuePerDays.OrderByDescending(u => u.RevenueId);
                MessageBox.Show(revenue.First().RevenueAmount.ToString() + "р.", "Выручка за день составляет:");
            }
        }
    }
}
