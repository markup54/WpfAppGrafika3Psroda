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

namespace WpfAppGrafika3Psroda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<BitmapImage> Images { get; set; }
        public int Aktualny { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            przygotujObrazy();
            Aktualny = 0;
        }

        private void przygotujObrazy()
        {
            Images= new List<BitmapImage>();
            Images.Add(new BitmapImage(new Uri("grafika/rys1.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys2.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys3.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys4.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys5.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys6.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys7.jpg", UriKind.Relative)));
            Images.Add(new BitmapImage(new Uri("grafika/rys8.jpg", UriKind.Relative)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Aktualny--;
            if (Aktualny < 0)
            {
                Aktualny = Images.Count - 1;
            }
            obraz.Source = Images[Aktualny];

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Aktualny++;
            if (Aktualny == Images.Count)
                Aktualny = 0;
            obraz.Source = Images[Aktualny];
        }

        private void rys1_Checked(object sender, RoutedEventArgs e)
        {
            obrazek2.Source = new BitmapImage(new Uri("grafika/rys1.jpg",UriKind.Relative));
        }

        private void combo_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
