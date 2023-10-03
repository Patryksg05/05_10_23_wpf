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

namespace egzamin_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void confirm_btn_click(object sender, RoutedEventArgs e)
        {
        }

        private void check_price_btn(object sender, RoutedEventArgs e)
        {
            if(postcard.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/pocztowka.png", UriKind.Relative));
                price.Text = "Cena: 1zł";
            }
            else if(list.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/list.png", UriKind.Relative));
                price.Text = "Cena: 1,5zł";
            }
            else if(pack.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/paczka.png", UriKind.Relative));
                price.Text = "Cena: 10zł";
            }
        }
    }
}
