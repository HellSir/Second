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
    /// Логика взаимодействия для MedicinesWin.xaml
    /// </summary>
    public partial class MedicinesWin : Window
    {
        public MedicinesWin()
        {
            InitializeComponent();
            GetPred(0);
        }

        private void GetPred(int index)
        {
            using (Model1 model = new Model1())
            {

                var query = from s in model.Лекарства
                            select s;

                foreach (var item in query)
                {
                    if (item.Код_лекарства == index)
                    {
                        code.Text = item.Код_лекарства.ToString();
                        name.Text = item.Наименование;
                        oklad.Text = item.Показания.ToString();
                        duties.Text = item.Противопоказания;
                        requirements.Text = item.Упаковка;
                        cost.Text = item.Стоимость.ToString();


                        IndexText.Text = item.Код_лекарства.ToString();
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
