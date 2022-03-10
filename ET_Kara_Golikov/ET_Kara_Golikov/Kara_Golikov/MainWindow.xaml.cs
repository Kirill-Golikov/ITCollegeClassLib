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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_Kara_Golikov;

namespace Kara_Golikov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Fill_Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> StudMassFio = new List<string>();
            List<int> StudMassYear = new List<int>();
            List<int> StudMassGroup = new List<int>();


            Students st0 = new Students();
            st0.fio = "Тимошин Василий Игнатьевич";
            StudMassFio.Add(st0.fio);
            st0.year = 2000;

            st0.group = 01;

            Students st1 = new Students();
            st1.fio = "Колесов Ануфрий Парфеньевич";
            StudMassFio.Add(st0.fio);
            st1.year = 2000;
            st1.group = 01;

            Students st2 = new Students();
            st2.fio = "Титов Ярополк Иванович";
            StudMassFio.Add(st0.fio);
            st2.year = 2000;
            st2.group = 01;

            Students st3 = new Students();
            st3.fio = "Луговой Сергей Робертович";
            StudMassFio.Add(st0.fio);
            st3.year = 2001;
            st3.group = 02;

            Students st4 = new Students();
            st4.fio = "Красильникова Жанна Борисовна";
            StudMassFio.Add(st0.fio);
            st4.year = 2001;
            st4.group = 02;


        }

        private void GenMark_Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> Mark = new List<string> { "2", "3", "4", "5" };
            //Mark GetMarks(DateTime now, List<string> Students);
        }

        private void MinAVG_Button_Click(object sender, RoutedEventArgs e)
        {
            double MinAvg(string[] marks);
        }

        private void Truancy_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Disease_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudNumber_Button_Click(object sender, RoutedEventArgs e)
        {
            StudNumber gsn = new StudNumber();
            MessageBox.Show(Students(st0));
            string number = gsn.StudNumber(st0.fio, st0.year, st0.group);
        }
    }
}
}
