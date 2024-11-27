using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практика_11
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

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программу подготовил студент группы ИСП-31 Лотаков Артемий\nПрактическая 11 Вариант 13\nДана строка 'aa aba abba abbba abbbba abbbbba'. Напишите регулярное выражение, которое найдет строки вида aba, в которых 'b' встречается более 4-х раз (включительно). Дана строка 'avb a1b a2b a3b a4b a5b abb acb'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не число.", "О программе");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRez1_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear(); // Очищаем элементы в listBox1 перед выводом новых данных
            string line = "aa aba abba abbba abbbba abbbbba"; // Определяем строку для регулярного выражения
            outLine1.Text = line;
            Regex regex = new Regex("a(b{4,})a"); // Создаем объект регулярного выражения для поиска строк вида "a", за которым следует 4 или более "b", и снова "a"
            MatchCollection match = regex.Matches(line); // Находим все соответствия регулярного выражения в строке.
            for (int i = 0; i < match.Count; i++) // Цикл по всем найденным совпадениям
            {
                listBox1.Items.Add(match[i]); // Добавляем каждое найденное совпадение в список listBox1
            }
        }

        private void btnRez_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Clear();
            string line = "avb a1b a2b a3b a4b a5b abb acb";
            outLine2.Text = line;
            Regex regex = new Regex("a[^0-9]b"); // Создаем объект регулярного выражения для поиска строк, где буквы "a" и "b" разделены нецифровым символом
            MatchCollection match = regex.Matches(line);
            for (int i = 0; i < match.Count; i++)
            {
                listBox2.Items.Add(match[i]);
            }
        }
    }
}