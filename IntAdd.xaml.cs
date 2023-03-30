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
    /// Логика взаимодействия для IntAdd.xaml
    /// </summary>
    public partial class IntAdd : Window
    {
        AppContext db = new AppContext();
        public IntAdd()
        {
            InitializeComponent();
        }

        private void IntAddBackBtn_Click(object sender, RoutedEventArgs e)
        {
            InteriorWindow interiorWindow = new InteriorWindow();
            interiorWindow.Show();
            this.Close();
        }

        private void IntSaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string mark = MarkIntTb.Text.Trim();
            string type = TypeIntTb.Text.Trim();
            string coast = CoastIntTb.Text.Trim();

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

                Interior interior = new Interior(mark, type, coast);
                db.Interiors.Add(interior);
                db.SaveChanges();

                InteriorWindow intwin = new InteriorWindow();
                intwin.Show();
                this.Close();
           
            }
        }
    }
}
