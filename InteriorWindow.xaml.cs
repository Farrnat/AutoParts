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
    /// Логика взаимодействия для InteriorWindow.xaml
    /// </summary>
    public partial class InteriorWindow : Window
    {
        AppContext db = new AppContext();
        public InteriorWindow()
        {
            InitializeComponent();
            List<Interior> interiors = db.Interiors.ToList();
        }

        private void InterBackBtn_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InteriorGrid.ItemsSource = db.Interiors.ToList();
        }

        private void IntAddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IntDelBtn_Click(object sender, RoutedEventArgs e)
        {
            var Current = InteriorGrid.SelectedItem as Interior;
            db.Interiors.Remove(Current);
            db.SaveChanges();
            InteriorGrid.ItemsSource = db.Interiors.ToList();
        }
    }
}
