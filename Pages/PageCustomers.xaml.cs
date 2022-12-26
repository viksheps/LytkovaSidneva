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
    /// Логика взаимодействия для PageCustomers.xaml
    /// </summary>
    public partial class PageCustomers : Page
    {
        public PageCustomers()
        {
            InitializeComponent();
            dtgrDoc.ItemsSource = ConnectDB.entObj.Customer.ToList();
            cmb.SelectedValuePath = "IdCustomer";
            cmb.DisplayMemberPath = "IdCustomer";

            cmb.ItemsSource = ConnectDB.entObj.Customer.ToList();
        }

        private void ClBa(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageHello());
        }

        private void cmb_S(object sender, SelectionChangedEventArgs e)
        {
            int Famid = (int)cmb.SelectedValue;
            dtgrDoc.ItemsSource = ConnectDB.entObj.Customer.Where(x => x.IdCustomer == Famid).ToList();
        }

        private void btnDel(object sender, RoutedEventArgs e)
        {
            Customer ln = dtgrDoc.SelectedItem as Customer;
            if (ln == null)
            {
                MessageBox.Show("Запись не выбрана", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (MessageBox.Show("Хотите удалить выбранную запись?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ConnectDB.entObj.Customer.Remove(ln);
                    ConnectDB.entObj.SaveChanges();
                    dtgrDoc.ItemsSource = ConnectDB.entObj.Customer.ToList();
                }
            }
        }

        private void btnRed(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Pages.PageRedCustomers((sender as Button).DataContext as Customer));
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Pages.PageAddCustomers());
        }
    }
}
