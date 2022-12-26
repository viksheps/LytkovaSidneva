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
    /// Логика взаимодействия для PageAddOrder.xaml
    /// </summary>
    public partial class PageAddOrder : Page
    {
        public PageAddOrder()
        {
            InitializeComponent();
        }

        private void ClAdd(object sender, RoutedEventArgs e)
        {
            Order userObj = new Order()
            {
                NameOrder = txbS.Text,
                Price = Convert.ToInt32(txbNm.Text),
                Count = Convert.ToInt32(txH.Text),
                OrderDate = Convert.ToDateTime(txbN.Text),
                DateOfIssue= Convert.ToDateTime(tx.Text),
                IdCustomer = Convert.ToInt32(txC.Text),
            };
            ConnectDB.entObj.Order.Add(userObj);
            ConnectDB.entObj.SaveChanges();
            MessageBox.Show("Запись создана", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClBack(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Pages.PageOrder());
        }
    }
}
