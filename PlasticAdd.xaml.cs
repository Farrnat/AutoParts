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
    /// Логика взаимодействия для PlasticAdd.xaml
    /// </summary>
    public partial class PlasticAdd : Window
    {
        AppContext db = new AppContext();
        public PlasticAdd()
        {
            InitializeComponent();
        }

        private void PlastAddBackBtn_Click(object sender, RoutedEventArgs e)
        {
            PlasticWindow plasticWindow = new PlasticWindow();
            plasticWindow.Show();
            this.Close();
        }

        private void PlastAddSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string mark = PlastMarkTb.Text.Trim();
            string type = PlastTypeTb.Text.Trim();
            string coast = PlastCoastTb.Text.Trim();

            if (mark.Length < 1)
            {
                MessageBox.Show("Все поля должны быть заполненными");
            }
            else if (type.Length < 1)
            {
                MessageBox.Show("Все поля должны быть заполненными");
            }
            else if (coast.Length < 1)
            {
                MessageBox.Show("Все поля должны быть заполненными");
            }
            else
            {
                MessageBox.Show("Изменения сохранены");

                Plastic plastic = new Plastic(mark, type, coast);
                db.Plastics.Add(plastic);
                db.SaveChanges();

                PlasticWindow plasticWindow = new PlasticWindow();
                plasticWindow.Show();
                this.Close();
            }
        }
    }
}
