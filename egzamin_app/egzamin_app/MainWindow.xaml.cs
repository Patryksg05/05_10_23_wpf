using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
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
            if (post_code_text_box.Text.Length != 5)
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym!");
            else
            {
                int result;

                if(int.TryParse(post_code_text_box.Text, out result))
                {
                    if (result >= 0 && result <= 99999)
                        MessageBox.Show("Dane przesyłki zostały wprowadzone!");
                    else
                        MessageBox.Show("Kod pocztowy powinien sie składać z samych cyfr!");

                }
            }
            
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
