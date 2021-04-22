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

namespace Second.view
{
    /// <summary>
    /// Логика взаимодействия для StaffWin.xaml
    /// </summary>
    public partial class StaffWin : Window
    {
        public StaffWin()
        {
            InitializeComponent();
            GetPred(0);
            this.WindowState = WindowState.Maximized;
        }

        private void GetPred(int index)
        {
            using (Model1 model = new Model1())
            {

                var query = from s in model.Сотрудники
                            select s;

                foreach (var item in query)
                {
                    if (item.Код_сотрудника == index)
                    {
                        code.Text = item.Код_сотрудника.ToString();
                        name.Text = item.ФИО;
                        oklad.Text = item.Возраст.ToString();
                        duties.Text = item.Пол;
                        requirements.Text = item.Адрес;
                        cost.Text = item.Телефон.ToString();
                        number_pass.Text = item.Паспортные_данные.ToString();
                        code_dol.Text = item.Код_должности.ToString();



                        IndexText.Text = item.Код_сотрудника.ToString();
                    }
                }

            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GetPred(int.Parse(IndexText.Text) + 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetPred(int.Parse(IndexText.Text) - 1);
        }
    }
}
