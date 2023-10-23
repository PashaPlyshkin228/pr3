using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace prak3matrix
{
    public static class LibMatrix
    {
        public static int CountRows(int[,] matrix)
        {
            int M = matrix.GetLength(0); // Количество строк
            int N = matrix.GetLength(1); // Количество столбцов

            HashSet<int> firstRowSet = new HashSet<int>(); // Множество для хранения чисел в первой строке
            HashSet<int> currentRowSet = new HashSet<int>(); // Множество для хранения чисел в текущей строке

            // Заполняем первое множество числами из первой строки
            for (int j = 0; j < N; j++)
            {
                firstRowSet.Add(matrix[0, j]);
            }

            int Count = 0; // Счетчик похожих строк

            // Проходимся по каждой строке
            for (int i = 1; i < M; i++)
            {
                currentRowSet.Clear(); // Очищаем множество текущей строки

                // Заполняем множество числами из текущей строки
                for (int j = 0; j < N; j++)
                {
                    currentRowSet.Add(matrix[i, j]);
                }

                // Если множество текущей строки равно первому множеству, увеличиваем счетчик на 1
                if (currentRowSet.SetEquals(firstRowSet))
                {
                    Count++;
                }
                
            }
            return Count;
        }
    }
}
