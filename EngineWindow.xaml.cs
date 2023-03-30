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
    /// Логика взаимодействия для EngineWindow.xaml
    /// </summary>
    public partial class EngineWindow : Window
    {
        AppContext db = new AppContext();
        public EngineWindow()
        {
            InitializeComponent();

            //AppContext db = new AppContext();
            List<Engine> engines = db.Engines.ToList();
           // EnginesList.ItemsSource = engines;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow usp = new UserPageWindow();
            usp.Show();
            this.Close();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            EngineAdd ea = new EngineAdd();
            ea.Show();
            this.Close();

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //AppContext db = new AppContext();
            EnginesGrid.ItemsSource = db.Engines.ToList();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            var CurrentEngine = EnginesGrid.SelectedItem as Engine;
            db.Engines.Remove(CurrentEngine);
            db.SaveChanges();
            EnginesGrid.ItemsSource = db.Engines.ToList();
        }
    }
}
