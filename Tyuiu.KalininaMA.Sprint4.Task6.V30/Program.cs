using Tyuiu.KalininaMA.Sprint4.Task6.V30.Lib;

namespace Tyuiu.KalininaMA.Sprint4.Task4.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Калинина М.А. | Рппб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема : Двумерные массивы. (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Калинина Мария Александровна | Рппб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Береза\", \"Дуб\", \"Клён\", \"Сосна\",  *");
            Console.WriteLine("*  \"Пихта\", \"Осина\"], используя класс Array, выведите элементы        *");
            Console.WriteLine("* массива, длина которых больше 5 символов.\r\n                           *");



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var three = new string[] { "Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < three.Length; i++)
            {
                Console.WriteLine(three[i]);
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine(" Количество элементов, длина которых больше 5 символов: ");
            string[] res = ds.Calculate(three);

            foreach (string i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("***************************************************************************");


        }
    }
}