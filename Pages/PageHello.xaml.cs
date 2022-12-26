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
    /// Логика взаимодействия для PageHello.xaml
    /// </summary>
    public partial class PageHello : Page
    {
        public PageHello()
        {
            InitializeComponent();
        }

        private void ClOrd(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageOrder());
        }

        private void btnCus(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageCustomers());
        }
    }
}
