using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lecture_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лекция 4. Операторы continue и break. Одномерные массивы.
            // Способы работы с одномерными массивами. Сортировка одномерных массивов

            //#region Оператор continue
            //// Оператор continue - это оператор, который заставляет программу, 
            //// немедленно перейти к выполнению СЛЕДУЮЩЕй итерации цикла

            //#region Пример с одним циклом

            ////for (int i = 0; i < 10; i++)
            ////{
            ////    if (i == 5)
            ////    {
            ////        Console.WriteLine("Выполняется оператор continue");
            ////        continue;
            ////    }

            ////    Console.WriteLine("i = " + i);
            ////}

            //#endregion

            //#region Пример с вложенным циклом 

            ////for (int i = 0; i < 10; i++)
            ////{
            ////    for (int j = 0; j < 10; j++)
            ////    {
            ////        if (j == 5)
            ////        {
            ////            continue;
            ////        }

            ////        Console.WriteLine("i = {0}, j = {1}", i, j);
            ////    }
            ////}

            //#endregion
            //#endregion

            //#region Оператор break
            //// Оператор break - Это оператор, который вынуждает программу, 
            //// немедленно завершить выполнения цикла в котором прописан оператор break

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        // Завершает цикл на 56 строке
            //        break;
            //    }

            //    Console.WriteLine("i = {0}", i);
            //}

            //int j = 0;

            //while (true)
            //{
            //    if (j == 10)
            //    {
            //        // Завершает цикл на 68 строке
            //        break;
            //    }
            //    ++j;
            //}


            //#endregion

            #region Одномерные массивы
            // Объявление переменной - это выделение памяти под переменную, без 
            // присвоения значения.
            // Инициализация переменной - это присвоение значения переменной.

            // Объявление переменной
            int a;
            // Инициализация переменной
            a = 20;

            // Одновременное и объявили переменную и инициализировали
            int b = 30;

            // Массив - это множество элемент, 
            // имеющих одинаковый тип данных (однотипных элементов).

            // Одномерный массив - это массив, содержащий в себе одно измерение.
            // Геометрически одномерный массив - это вектор.

            // Основные свойства массивов : 
            // 1. Тип данных элементов, которые хранятся в массиве
            // 2. Количество элементов, которые могут хранится в массиве (длинна массива)
            // 3. Название массива.
            // 4. Количество измерений массива. Массивы могут иметь сколь-угодно большое 
            // количество измерений. [] - одномерный массив, [,] - двумерный массив, 
            // [,,] - трехмерный массив и т.д. .  

            // Пример объявления массива
            int[] arrayWithInts;
            // Инициализируем массив, состоящий из 3 элементов типа int
            arrayWithInts = new int[3];  // индексы 0, 1, 2
            // Элементы arrayWithInts = {0, 0, 0}

            // Для обращения к элементам массива (-ов), необходимо использовать индекс элемента массива.
            // При чем индексы элементов массива находятся в диапазоне от [0...n), где n - длинна массива

            // Присвоение значений элементам массива 
            arrayWithInts[0] = 10;
            arrayWithInts[1] = 20;
            arrayWithInts[2] = 30;

            // Вывод элементов массива на экран
            //Console.WriteLine(arrayWithInts[0]);
            //Console.WriteLine(arrayWithInts[1]);
            //Console.WriteLine(arrayWithInts[2]);

            // Инициализация массива, с явным указание значений элементов
            int[] arrayWithInts2 = { 10, 20, 30 };

            // Вывод элементов массива на экран
            //Console.WriteLine(arrayWithInts2[0]);
            //Console.WriteLine(arrayWithInts2[1]);
            //Console.WriteLine(arrayWithInts2[2]);

            // Example1();
            // Example2();
            Example3();
            #endregion

            // Delay
            Console.ReadKey();
        }

        static void Example1()
        {
            string[] arrayNames = { "Алексей", "Дмитрий", "Антон" };
            string[] arraySurnames = { "Фамилия1", "Фамилия2", "Фамилия3" };

            // 3*3 варианта = 9 вариантов

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int indexForName = random.Next(0, 3); // [0...3)
                int indexForSurName = random.Next(0, 3); // [0...3)

                string fullName = arrayNames[indexForName] + " " +
                    arraySurnames[indexForSurName];

                Console.WriteLine(fullName);
            }
        }

        static void Example2()
        {
            // Задан массив целочисленных значений, состоящий из N элементов. 
            // N вводится во время выполнения программы. Элементы массива, заполнить
            // случайным образом, исходя из диапазона от minLimit до maxLimit (вводятся пользователем).
            // Найти в массиве минимальное и максимальное значение.

            // Массив
            int[] array;
            // Количество элементов в массиве
            int N = 0;
            // Минимальный предел 
            int minLimit = 0;
            // Максимальный предел 
            int maxLimit = 0;
            // Минимальный элемент в массиве 
            int minValue = 0;
            // Максимальный элемент в массиве
            int maxValue = 0;

            Console.Write("Введите N : ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите minLimit : ");
            minLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите maxLimit : ");
            maxLimit = Convert.ToInt32(Console.ReadLine());

            // Создаем в памяти массив содержащий в себе N элементов типа int
            array = new int[N]; // {0, ... , 0, 0, ... , 0}

            // Создаём объект класса Random, для генерации случайных чисел
            Random random = new Random();

            // Заполняем массив случайными значениями
            // array.Length - длина массива. В нашем случае, array.Length = N
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minLimit, maxLimit);
            }

            // Вывод элементы массива на экран
            Console.Write("Исходный массив : ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            minValue = array[0];
            maxValue = array[0];

            // Поиск минимального элемента массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            // Поиск максимального элемента массива
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            // \n - перевод на новую строку
            Console.WriteLine("\nМаксимальное элемент в массиве : {0}", maxValue);
            Console.WriteLine("Минимальный элемент в массиве : {0}", minValue);
        }

        static void Example3()
        {
            // Найти сумму четных элементов массива целых чисел.

            int[] array = new int[10];
            int sum = 0;

            Random random = new Random();

            // Генерируем случайные элементы массива и выводим их на экран 
            Console.Write("Массив : ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(array[i] + " ");
            }

            // Перенос строки
            Console.WriteLine();

            #region Об остатке от деления 
            // 5/3 = 1 Остаток : 2
            // % - остаток от деления
            // 5%3 = 2
            // 10%2 = 0
            // 20%2 = 0
            // 3%2 = 1
            // Для четных чисел остаток от деления на 2 равен 0.
            // Для нечетных чисел остаток от деления на 2 равен 1.
            #endregion

            for (int i = 0; i < array.Length; i++)
            {
                // Если остаток от деления текущего элемента массива равен 0, 
                // то элемент массива является четным, и условие выполняется.
                if (array[i] % 2 == 0)
                {
                    // Прибавляем к сумме четных элементов массива, значение текущего элемента массива
                    sum += array[i];
                }
            }

            Console.WriteLine("Сумма четных элементов массива равна : {0}", sum);

            // CLR via C#
        }

    }
}
