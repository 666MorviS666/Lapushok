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

namespace Lapushok.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageDobavlenieRedact.xaml
    /// </summary>
    public partial class PageDobavlenieRedact : Page
    {
        public PageDobavlenieRedact()
        {
            InitializeComponent();
        }

        private void HLinkEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = (sender as Hyperlink).DataContext as Product;
            NavigationService.Navigate(new Pages.PageRedachProduct(selectedProduct));
        }

        private void HLinkDel_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = (sender as Hyperlink).DataContext as Product;
            Db.db.Ingredient.Remove(selectedProduct);
            Db.db.SaveChanges();
            
            MessageBox.Show("Ингредиент удален");
        }

        private void BTNAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
