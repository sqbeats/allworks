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

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Логика взаимодействия для pacients.xaml
    /// </summary>
    public partial class pacients : Page
    {
        public pacients()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            btnFirst.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#28AEED");
            btnSecond.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            fContainer.Navigate(new System.Uri("Pages2/nearestPatient.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThird_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
