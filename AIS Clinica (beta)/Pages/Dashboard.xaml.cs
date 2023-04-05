using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
using MySqlConnector;

namespace WPFModernVerticalMenu.Pages
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        public Dashboard()
        {
            InitializeComponent();

            fContainer.Navigate(new System.Uri("Pages2/dataTable.xaml", UriKind.RelativeOrAbsolute));
            btnFirst.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#28AEED");

        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            btnFirst.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#28AEED");
            btnSecond.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            btnThird.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            fContainer.Navigate(new System.Uri("Pages2/dataTable.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSecond_Click(object sender, RoutedEventArgs e)
        {
            btnFirst.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            btnSecond.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#28AEED");
            btnThird.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            fContainer.Navigate(new System.Uri("Pages2/personalFile.xaml", UriKind.RelativeOrAbsolute));

        }

        private void btnThird_Click(object sender, RoutedEventArgs e)
        {
            btnFirst.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            btnSecond.BorderBrush = (Brush)new BrushConverter().ConvertFrom("Transparent");
            btnThird.BorderBrush = (Brush)new BrushConverter().ConvertFrom("#28AEED");
            fContainer.Navigate(new System.Uri("Pages2/registration1.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
