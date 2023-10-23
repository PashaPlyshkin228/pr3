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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prak3matrix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[,] matrix;//создаем глобальную переменную массива
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info_Click(object sender, RoutedEventArgs e)//кнопка вывода информации о разработчике и варианте задания
        {
            MessageBox.Show("Коннов Вадим ИСП-34 \n Дана целочисленная матрица размера M × N, элементы которой могут принимать\r\nзначения от 0 до 100. Различные строки матрицы назовем похожими, если\r\nсовпадают множества чисел, встречающихся в этих строках. Найти количество\r\nстрок, похожих на первую строку данной матрицы. ");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)//кнопка выхода из программы
        {
            this.Close();
        }

        private void GenerateMatrix_Click(object sender, RoutedEventArgs e)//кнопка генерации матрицы
        {
            if (int.TryParse(stroki.Text, out int m) && int.TryParse(stolb.Text, out int n) && m > 0 && n > 0)//запускаем цикл if на проверку ввода корректных значений
            {
                matrix = Mas.GenerateMas(m, n);//вызываем написанный нами класс,который создает массив и заполняет его случайными значениями
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrica.Text += matrix[i, j] + "\t";
                    }
                    matrica.Text += "\n";
                }
            }
            else
            {
                MessageBox.Show("Введите корректные значения для количества строк и столбцов", "Achtung!");//сообщение об ошибке
            }
        }

        private void Resultat_Click(object sender, RoutedEventArgs e)//кнопка выполнения функции программы
        {
            if (matrix != null)//проверка на ошибки
            {
                int count = LibMatrix.CountRows(matrix);//вызываем созданный нами класс для выполнения функции по варианту задания
                rez.Text =count.ToString();//выводим результат в текстовое поле
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте матрицу", "Achtung!");//сообщение об ошибке
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)//очищает текстовые поля нашей программы
        {
            rez.Clear();
            stolb.Clear();
            stroki.Clear();
            matrica.Clear();
            matrix = null;
        }
    }
}
