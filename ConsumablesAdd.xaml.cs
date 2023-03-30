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
    /// Логика взаимодействия для ConsumablesAdd.xaml
    /// </summary>
    public partial class ConsumablesAdd : Window
    {
        AppContext db = new AppContext();
        public ConsumablesAdd()
        {
            InitializeComponent();
        }

        private void ConsSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string mark = ConsMarkTb.Text.Trim();
            string type = ConsTypeTb.Text.Trim();
            string coast = ConsCoastTb.Text.Trim();

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

                Consumable consumable = new Consumable(mark, type, coast);
                db.Consumables.Add(consumable);
                db.SaveChanges();

                ConsumablesWindow consumablesWindow = new ConsumablesWindow();
                consumablesWindow.Show();
                this.Close();
            }
        }
        private void ConsAddBackBtn_Click(object sender, RoutedEventArgs e)
        {
            ConsumablesWindow consumablesWindow = new ConsumablesWindow();
            consumablesWindow.Show();
            this.Close();
        }
    }
}
