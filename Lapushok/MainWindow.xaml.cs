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

namespace Lapushok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _currentPage = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTNPredStr_Click(object sender, RoutedEventArgs e)
        {
            _currentPage--;
        }

        private void BTNSledStr_Click(object sender, RoutedEventArgs e)
        {
            _currentPage++;
        }


        private void BDobavlenieRedach_Click(object sender, RoutedEventArgs e)
        {
            MoyaRamka.Navigate(new Pages.PageDobavlenieRedact());
        }

        private void BProduct_Click(object sender, RoutedEventArgs e)
        {

            MoyaRamka.Navigate(new Pages.PageProduct());
        }
    }
}
