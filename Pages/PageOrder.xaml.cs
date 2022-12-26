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
    /// Логика взаимодействия для PageOrder.xaml
    /// </summary>
    public partial class PageOrder : Page
    {
        public PageOrder()
        {
            InitializeComponent();
            dtgrDoc.ItemsSource = ConnectDB.entObj.Order.ToList();
            cmb.SelectedValuePath = "IdOrder";
            cmb.DisplayMemberPath = "IdOrder";

            cmb.ItemsSource = ConnectDB.entObj.Order.ToList();
        }

        private void ClBa(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageHello());
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddOrder());
        }

        private void btnDel(object sender, RoutedEventArgs e)
        {
            Order ln = dtgrDoc.SelectedItem as Order;
            if (ln == null)
            {
                MessageBox.Show("Запись не выбрана", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (MessageBox.Show("Хотите удалить выбранную запись?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ConnectDB.entObj.Order.Remove(ln);
                    ConnectDB.entObj.SaveChanges();
                    dtgrDoc.ItemsSource = ConnectDB.entObj.Order.ToList();
                }
            }
        }

        private void cmb_S(object sender, SelectionChangedEventArgs e)
        {
            int Famid = (int)cmb.SelectedValue;
            dtgrDoc.ItemsSource = ConnectDB.entObj.Order.Where(x => x.IdOrder == Famid).ToList();
        }

        private void btnRed(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Pages.PageRedOrder((sender as Button).DataContext as Order));
        }
    }
}
