using System;
using System.Collections.Generic;
using System.Diagnostics;
using SortingAlgorithms.Algorithms;

namespace SortingAlgorithms
{
    internal class Program
    {
        private static Stopwatch _sw = new Stopwatch();

        static void Main()
        {
            List<int> lengthList = new List<int> { 1000, 2000, 3000, 4000};

            double timeWork;
            double[] sortTime = { 0, 0, 0, 0, 0, 0, 0, 0, 0};

            foreach (var currentLength in lengthList)
            {
                Console.WriteLine($"----------     Количество элементов массива {currentLength}    ----------");

                int[] array = new int[currentLength];
                int[] newArray = new int[currentLength];

                FillArray(array);

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.StupidSort, newArray, out timeWork);
                Console.WriteLine($"1. Время работы алгоритма Тупая Сортировка: {timeWork}");
                sortTime[0] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.BubbleSort, newArray, out timeWork);
                Console.WriteLine($"2. Время работы алгоритма Пузырьковая Сортировка: {timeWork}");
                sortTime[1] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.CocktailSort, newArray, out timeWork);
                Console.WriteLine($"3. Время работы алгоритма Коктейльная Сортировка: {timeWork}");
                sortTime[2] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.InsertionSort, newArray, out timeWork);
                Console.WriteLine($"4. Время работы алгоритма Сортировки Простыми Вставками: {timeWork}");
                sortTime[3] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.GnomeSort, newArray, out timeWork);
                Console.WriteLine($"5. Время работы алгоритма Гномья Сортировка: {timeWork}");
                sortTime[4] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.SelectionSort, newArray, out timeWork);
                Console.WriteLine($"6. Время работы алгоритма Сортировка Выбором: {timeWork}");
                sortTime[5] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.ShellSort, newArray, out timeWork);
                Console.WriteLine($"7. Время работы алгоритма Сортировка Шелла: {timeWork}");
                sortTime[6] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.QuickSort, newArray, 0, newArray.Length - 1, out timeWork);
                Console.WriteLine($"8. Время работы алгоритма Быстрая Cортировка: {timeWork}");
                sortTime[7] += timeWork;

                Array.Copy(array, newArray, array.Length);
                StartTest(Sorting.MergeSort, newArray, out timeWork);
                Console.WriteLine($"9. Время работы алгоритма Сортировка Слиянием: {timeWork}");
                sortTime[8] += timeWork;

                Console.WriteLine("\n\n");
            }
            Console.WriteLine("Общее время работы каждого алгоритма по всем длиннам массива");
            for (int i = 0; i < sortTime.Length; i++)
            {
                Console.WriteLine($"{i+1}: {Math.Round(sortTime[i] / sortTime.Length, 4)}");
            }

            Console.Write("y/n to continue/close console... ");

            switch (Console.ReadLine())
            {
                case "y": Main(); break;
                case "n": Environment.Exit(0); break;
            }
        }

        private static void StartTest(Action<int[]> action, int[] array, out double timeWork)
        {
            timeWork = 0;

            for (int i = 1; i <= 10; i++)
            {
                _sw.Reset();

                _sw.Start();

                action(array);

                _sw.Stop();

                timeWork += _sw.ElapsedMilliseconds;
            }

            timeWork = timeWork / 10;
        }

        private static void StartTest(Action<int[], int, int> action, int[] array, int left, int right, out double timeWork)
        {
            timeWork = 0;

            for (int i = 1; i <= 10; i++)
            {
                _sw.Reset();

                _sw.Start();

                action(array, left, right);

                _sw.Stop();

                timeWork += _sw.ElapsedMilliseconds;
            }

            timeWork = timeWork / 10;
        }

        private static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(-array.Length, array.Length);
        }
    }
}
