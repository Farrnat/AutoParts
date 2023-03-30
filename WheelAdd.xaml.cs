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
    /// Логика взаимодействия для WheelAdd.xaml
    /// </summary>
    public partial class WheelAdd : Window
    {
        AppContext db = new AppContext();
        public WheelAdd()
        {
            InitializeComponent();
        }

        private void WheelAddBackBtn_Click(object sender, RoutedEventArgs e)
        {
            WheelsWindow wheelsWindow = new WheelsWindow();
            wheelsWindow.Show();
            this.Close();
        }

        private void WheelAddSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string mark = WheelMarkTb.Text.Trim();
            string type = WheelTypeTb.Text.Trim();
            string coast = WheelCoastTb.Text.Trim();

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

                Wheel wheel = new Wheel(mark, type, coast);
                db.Wheels.Add(wheel);
                db.SaveChanges();

                WheelsWindow wheelsWindow = new WheelsWindow();
                wheelsWindow.Show();
                this.Close();
            }
        }
    }
}
