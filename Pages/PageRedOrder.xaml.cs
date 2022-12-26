﻿using System;
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
    /// Логика взаимодействия для PageRedOrder.xaml
    /// </summary>
    public partial class PageRedOrder : Page
    {
        public PageRedOrder(Order order)
        {
            InitializeComponent();
            ListJournal.ItemsSource = ConnectDB.entObj.Order.Where(x => x.IdOrder == order.IdOrder).ToList();
        }

        private void ClBa(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageOrder());
        }

        private void ClSaveAdre(object sender, RoutedEventArgs e)
        {
            ConnectDB.entObj.SaveChanges();
            MessageBox.Show(
            "Данные успешно изменены!",
            "Уведомление",
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }
    }
}
