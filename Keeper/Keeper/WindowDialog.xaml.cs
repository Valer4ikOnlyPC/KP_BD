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
using System.Windows.Shapes;

namespace Keeper
{
    /// <summary>
    /// Логика взаимодействия для WindowDialog.xaml
    /// </summary>
    public partial class WindowDialog : Window
    {
        public WindowDialog()
        {
            InitializeComponent();
            Update();
        }
        public void Update()
        {
            using (ValeraDBContext db = new ValeraDBContext())
            {
                var revenue = db.RevenuePerDays.ToArray();
                ListViewRevenue.ItemsSource = revenue;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
