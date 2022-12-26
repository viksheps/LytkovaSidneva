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
using LytkovaSidneva.Classess;

namespace LytkovaSidneva.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddCustomers.xaml
    /// </summary>
    public partial class PageAddCustomers : Page
    {
        public PageAddCustomers()
        {
            InitializeComponent();
        }

        private void ClAdd(object sender, RoutedEventArgs e)
        {
            Customer userObj = new Customer()
            {
                FistName = txbS.Text,
                LastName = txbNm.Text,
                phone = Convert.ToInt32(txH.Text),
                adress = txbN.Text,
            };
            ConnectDB.entObj.Customer.Add(userObj);
            ConnectDB.entObj.SaveChanges();
            MessageBox.Show("Запись создана", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageCustomers());
        }
    }
}
