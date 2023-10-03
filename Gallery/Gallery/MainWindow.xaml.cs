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

namespace Gallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>();
        int image_id = 0;
        public MainWindow()
        {
            InitializeComponent();
            list.Add("images/forest1.jpg");
            list.Add("images/forest2.jpg");
            list.Add("images/forest3.jpg");
        }

        private void left_click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(list.Count.ToString());
            image_id--;
            if (image_id < 0)
            {
                image_id = list.Count - 1;
            }
            image.Source = new BitmapImage(new Uri(list[image_id], UriKind.Relative));
        }

        private void right_click(object sender, RoutedEventArgs e)
        {
            image_id++;
            if (image_id >= list.Count)
            {
                image_id = 0;
            }
            image.Source = new BitmapImage(new Uri(list[image_id], UriKind.Relative));
        }

        private void confirm_btn(object sender, RoutedEventArgs e)
        {
            int num;
            if (int.TryParse(image_id_text_box.Text, out num))
            {
                if (num >= 1 && num < list.Count+1)
                {
                    image.Source = new BitmapImage(new Uri(list[num-1], UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("range!");
                }
            }
        }
    }
}
