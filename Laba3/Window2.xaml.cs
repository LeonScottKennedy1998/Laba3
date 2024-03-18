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

namespace Laba3
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private DogPriutEntities dogpriut = new DogPriutEntities();
        List<ForAdopters> foradopters = new List<ForAdopters>();
        public Window2()
        {
            InitializeComponent();
            foreach (var item in dogpriut.Adopters.ToList())
            {
                foradopters.Add(new ForAdopters(item));
            }
            Grid2.ItemsSource = foradopters;
        }
    }
}
