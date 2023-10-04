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

namespace image_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> list = new List<String>();
        public MainWindow()
        {
            InitializeComponent();
            list.Add("images/forest1.jpg");
            list.Add("images/forest2.jpg");
            list.Add("images/forest3.jpg");
            list.Add("images/forest4.jpg");
            list.Add("images/forest5.jpg");
        }

        private void select_from_radio_click(object sender, RoutedEventArgs e)
        {
            if(image1.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest1.jpg", UriKind.Relative));
            }
            else if(image2.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest2.jpg", UriKind.Relative));
            }
            else if(image3.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest3.jpg", UriKind.Relative));
            }
            else if(image4.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest4.jpg", UriKind.Relative));
            }
        }

        private void select_from_index_btn(object sender, RoutedEventArgs e)
        {
            int index;
            if (int.TryParse(index_text_box.Text, out index) && (index >= 1 && index < 6))
            {
                image.Source = new BitmapImage(new Uri(list[index-1], UriKind.Relative));
            }
            else
                MessageBox.Show("range!");
        }
    }
}
