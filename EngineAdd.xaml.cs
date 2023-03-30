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
    /// Логика взаимодействия для EngineAdd.xaml
    /// </summary>
    public partial class EngineAdd : Window
    {

        AppContext db = new AppContext();
        public EngineAdd()
        {
            InitializeComponent();
            
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            EngineWindow ew = new EngineWindow();
            ew.Show();
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string mark = MarkTb.Text.Trim();
            string type = TypeTb.Text.Trim();
            string coast = CoastTb.Text.Trim();

            if(mark.Length < 1 )
            {
                MessageBox.Show("Все поля должны быть заполненными");

            }
            else if(type.Length < 1 )
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

                Engine engine = new Engine(mark, type, coast);
                db.Engines.Add(engine);
                db.SaveChanges();

                EngineWindow ew = new EngineWindow();
                ew.Show();
                this.Close();
            }


        }
    }
}
