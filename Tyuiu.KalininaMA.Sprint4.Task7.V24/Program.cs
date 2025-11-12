using Tyuiu.KalininaMA.Sprint4.Task7.V24.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int rows = 5;
            int columns = 3;

            int[,] numbers = new int[rows, columns];
            string str = "651827384219648";
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема : Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"651827384219648\".                  *");
            Console.WriteLine("* Преобразуйте ее в матрицу 5 на 3 и подсчитайте произведение             *");
            Console.WriteLine("* четных чисел.                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");


            int index = 0;

            Console.WriteLine("\nМассив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);
            Console.WriteLine("Произведение четных чисел = " + res );


            Console.ReadLine();
        }
    }
}