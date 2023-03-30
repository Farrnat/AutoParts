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
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();

        }

        private void Button_Engine_Window_Click(object sender, RoutedEventArgs e)
        {
            EngineWindow engineWindow = new EngineWindow();
            engineWindow.Show();
            Hide();
        }


        private void InterBtn_Click(object sender, RoutedEventArgs e)
        {
            InteriorWindow interiorWindow = new InteriorWindow();
            interiorWindow.Show();
            this.Close();
        }

        private void GearBtn_Click(object sender, RoutedEventArgs e)
        {
            GearWindow gearWindow = new GearWindow();
            gearWindow.Show();
            this.Close();
        }

        private void PlasticBtn_Click(object sender, RoutedEventArgs e)
        {
            PlasticWindow plasticWindow = new PlasticWindow();
            plasticWindow.Show();
            this.Close();
        }

        private void ConsBtn_Click(object sender, RoutedEventArgs e)
        {
            ConsumablesWindow consWindow = new ConsumablesWindow();
            consWindow.Show();
            this.Close();
        }

        private void WheelBtn_Click(object sender, RoutedEventArgs e)
        {
            WheelsWindow wheelsWindow = new WheelsWindow();
            wheelsWindow.Show();
            this.Close();
        }
    }
}
