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
using System.Windows.Shapes;
using Laba3.PriutDSTableAdapters;

namespace Laba3
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        AdoptersTableAdapter adopters = new AdoptersTableAdapter();
        public Window3()
        {
            InitializeComponent();
            Grid3.ItemsSource = adopters.GetFullTable();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Grid3.Columns[0].Visibility = Visibility.Hidden;
            Grid3.Columns[8].Visibility = Visibility.Hidden;
        }
    }
}
