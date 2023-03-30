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

namespace AutoParts
{
    /// <summary>
    /// Логика взаимодействия для GearWindow.xaml
    /// </summary>
    public partial class GearWindow : Window
    {
        AppContext db = new AppContext();
        public GearWindow()
        {
            InitializeComponent();
        }

        private void GearBackBtn_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GearDataGrid.ItemsSource = db.Gears.ToList();
        }

        private void GearAddBtn_Click(object sender, RoutedEventArgs e)
        {
            GearAdd gearAdd = new GearAdd();
            gearAdd.Show();
            this.Close();
        }

        private void GearDelBtn_Click(object sender, RoutedEventArgs e)
        {
            var Current = GearDataGrid.SelectedItem as Gear;
            db.Gears.Remove(Current);
            db.SaveChanges();
            GearDataGrid.ItemsSource = db.Gears.ToList();
        }
    }
}
