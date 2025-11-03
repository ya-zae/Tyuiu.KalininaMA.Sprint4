using Tyuiu.KalininaMA.Sprint4.Task3.V12.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема : Одномерные массивы. (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 9. Найдите минимальный      *");
            Console.WriteLine("* элемент третьем столбце массива.                                        *");

            int[,] mas = new int[5, 5] { { 9, 7, 4, 9, 7 },
                                         { 5, 2, 5, 7, 6 },
                                         { 8, 3, 3, 5, 7 },
                                         { 8, 4, 2, 4, 5 },
                                         { 8, 8, 9, 5, 6 } };
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas);

            Console.WriteLine("Минимальный элемент в третьем столбце массива = " + res);
            Console.ReadKey();

        }
    }
}