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
        int image_id = 0;
        public MainWindow()
        {
            InitializeComponent();
            list.Add("images/forest1.jpg");
            list.Add("images/forest2.jpg");
            list.Add("images/forest3.jpg");
            list.Add("images/forest4.jpg");
        }

        private void select_from_radio_click(object sender, RoutedEventArgs e)
        {
            if (image1.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest1.jpg", UriKind.Relative));
            }
            else if (image2.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest2.jpg", UriKind.Relative));
            }
            else if (image3.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest3.jpg", UriKind.Relative));
            }
            else if (image4.IsChecked == true)
            {
                image.Source = new BitmapImage(new Uri("../../../images/forest4.jpg", UriKind.Relative));
            }
        }

        private void select_from_index_btn(object sender, RoutedEventArgs e)
        {
            int index;
            if (int.TryParse(index_text_box.Text, out index) && (index >= 1 && index < 5))
            {
                image.Source = new BitmapImage(new Uri(list[index - 1], UriKind.Relative));
            }
            else
                MessageBox.Show("range!");
        }

        private void left_btn_click(object sender, RoutedEventArgs e)
        {
            image_id--;
            if(image_id < 0)
            {
                image_id = list.Count - 1;
            }
            image.Source = new BitmapImage(new Uri(list[image_id], UriKind.Relative));
        }

        private void right_btn_click(object sender, RoutedEventArgs e)
        {
            image_id++;
            if(image_id == list.Count)
            {
                image_id = 0;
            }
            image.Source = new BitmapImage(new Uri(list[image_id], UriKind.Relative));
        }

        private void generate_password_click(object sender, RoutedEventArgs e)
        {
            const string lower_case = "abcdefgijklmnoprstwuxyz";
            const string upper_case = "ABCDEFGHIJKLOMNOPRSTWUXYZ";

            string result_pass = string.Empty;
            string all_chars = string.Empty;
            Random random = new Random();
            int checkbox_counter = 0;

            if(small_caps.IsChecked == true)
            {
                all_chars += lower_case;
                checkbox_counter++;
            }

            if(upper_caps.IsChecked == true)
            {
                all_chars += upper_case;
                checkbox_counter++;   
            }

            string pass = string.Empty;
            for(int i=0; i<10; i++)
            {
                pass += all_chars[random.Next(0, all_chars.Length - 1)];
            }
            generated_pass_text_block.Text = pass;
        }

        private void generate_random_login(object sender, RoutedEventArgs e)
        {
            string login = user_login_text_box.Text;
            Random random = new Random();
            string three_chars;
            if(login == string.Empty) {
                MessageBox.Show("Fill input!");
            }
            else
            {
                three_chars = login.Substring(0, 3);
                char[] ar = three_chars.ToCharArray();
                int n = ar.Length;
                while(n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    var x = ar[k];
                    ar[k] = ar[n];
                    ar[n] = x;
                }
                string result = new string(ar);
                MessageBox.Show(result);
            }
        }
    }
}
