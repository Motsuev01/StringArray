using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas = { "Привет!", "Салют", "Hi", "Yes", "Арбуз", "12" };


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Исходный массив строк:\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            int count = 0; //счётчик строк, длина которых <=3
            foreach (var item in mas)
            {
                Console.WriteLine(item);
                if (item.Length <= 3) count++;
            }

            if (count == 0)
            {
                Console.WriteLine("\nВ массиве нет строк длина которых <=3");
            }
            else
            {
                string[] newMas = new string[count];

                int index = 0;
                foreach (var item in mas)
                {
                    if (item.Length <= 3)
                    {
                        newMas[index] = item;
                        index++;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nНовый массив из строк, длина которых <=3:");

                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var item in newMas)
                {
                    Console.WriteLine(item);
                }

                Console.ForegroundColor = ConsoleColor.Gray;
            }


            Console.WriteLine("\n\nКонец. Для выхода нажмите Enter");
            Console.ReadKey();

        }
    }
}
