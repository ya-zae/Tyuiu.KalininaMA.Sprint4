using Tyuiu.KalininaMA.Sprint4.Task4.V29.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема : Одномерные массивы. (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 8. Найдите сумму четных     *");
            Console.WriteLine("* элементов массива.                                                      *");

            int[,] mas = new int[5, 5] { { 5, 6, 5, 6, 5, },
                                         { 5, 6, 5, 6, 5, },
                                         { 8, 5, 5, 8, 8, },
                                         { 6, 5, 4, 4, 8, },
                                         { 8, 5, 6, 8, 8, }, }; 
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");


            int[,] matrix = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Элемент [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine($"Сумма четных элементов массива: {ds.Calculate(matrix)}");
            Console.WriteLine("***************************************************************************");


        }
    }
}