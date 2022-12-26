using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Pract11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            result1.Clear();
            result2.Clear();
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'aa aba abba abbba abca abea'."+
            "Напишите регулярное выражение, которое найдет строки aa, aba, abba, abbba."+
            "Дана строка 'a1a a2a a3a a4a a5a aba aca'. Напишите регулярное выражение,"+
            "которое найдет строки, в которых по краям стоят буквы 'a', а между ними одна цифра.");
        }
        
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Выполнить_Click(object sender, RoutedEventArgs e)
        {
            result1.Clear();
            result2.Clear();

            string s1 = "aa aba abba abbba abca abea";//создаем переменную с1 и записываем в нее нужную строчку
            Regex regex1 = new ("ab{0,3}a");//создаем объект класса р..1 и пишем что нам надо найти 
            MatchCollection matches1 = regex1.Matches(s1);// находим искомых значений 
            object[] array1 = new object[matches1.Count];// создаем массив
            matches1.CopyTo(array1, 0);// копируем его в матч1
            for (int i = 0; i < array1.Length; i++)// проходимся по массиву
            {
                result1.Text += $"{array1[i]}" + " ";//записываем в результат полученные значения 
            }

            string s2 = "a1a a2a  a3a a4a a5a aba aca";
            Regex regex2 = new("a[1-9]a");
            MatchCollection matches2 = regex2.Matches(s2);
            object[] array2 = new object[matches2.Count];
            matches2.CopyTo(array2, 0);
            for (int i = 0; i < array2.Length; i++)
            {
                result2.Text += $"{array2[i]}" + " ";
            }
        }
    }
}
