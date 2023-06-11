using System;
namespace SortingAlgorithms.Algorithms
{
    public class Sorting
    {

        public static void StupidSort(int[] array)
        {
            int i = 0;
            while(i < array.Length - 1)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                    i = 0;
                }
                else
                {
                    i++;
                }              
            }
        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        public static void CocktailSort(int[] array)
        {
            int right = array.Length;
            int left = 0;

            while (left <= right)
            {
                for (int i = left; i < right - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
                left++;
                for (int i = right - 1; i >= left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(array, i, i - 1);
                    }
                }
                right--;
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var key = array[i];
                int j = i - 1;
                while (j >= 0 && key < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        public static void GnomeSort(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                if (i == 0 || array[i] >= array[i - 1])
                {
                    i++;
                }
                else
                {
                    Swap(array, i, i - 1);
                    i--;
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min_index] > array[j])
                    {
                        min_index = j;
                    }
                }
                Swap(array, i, min_index);
            }
        }

        public static void ShellSort(int[] array)
        {
            int d = array.Length;
            while (d > 0)
            {
                for (int i = d; i < array.Length; i++)
                {
                    var key = array[i];
                    int j = i;
                    while (j >= d && key < array[j - d])
                    {
                        array[j] = array[j - d];
                        j -= d;
                    }
                    array[j] = key;
                }
                d /= 2;
            }
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int m = Split(array, left, right);
            QuickSort(array, left, m - 1);
            QuickSort(array, m + 1, right);
        }

        private static int Split(int[] array, int left, int right)
        {
            int keyIndex = left + (right - left) / 2;
            int x = array[keyIndex];

            Swap(array, keyIndex, right); // Помещаем опорный элемент в конец

            int j = left;
            for (int i = left; i < right; i++)
            {
                if (array[i] < x)
                {
                    Swap(array, i, j);
                    j++;
                }
            }

            Swap(array, j, right); // Возвращаем опорный элемент на правильную позицию
            return j;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1]; // Создаем временный массив для слияния

            int i = left; // Индекс для первого подмассива
            int j = mid + 1; // Индекс для второго подмассива
            int k = 0; // Индекс для временного массива

            // Слияние двух подмассивов во временный массив
            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            // Копирование оставшихся элементов из первого подмассива, если они есть
            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            // Копирование оставшихся элементов из второго подмассива, если они есть
            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            // Копирование элементов из временного массива обратно в основной массив arr
            for (int p = 0; p < temp.Length; p++)
            {
                arr[left + p] = temp[p];
            }
        }

        // Метод для итеративного слияния и сортировки массива
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            int currSize;

            // Последовательно слияние подмассивов различного размера
            // начиная с 1, затем 2, 4, 8 и т.д.
            for (currSize = 1; currSize <= n - 1; currSize = 2 * currSize)
            {
                // Обработка подмассивов один за другим с левого края массива до n-1
                for (int left = 0; left < n - 1; left += 2 * currSize)
                {
                    // mid точка слияния подмассивов
                    // mid = left + currSize - 1, если остаточный подмассив имеет размер < 2 * currSize
                    // в противном случае, mid = left + 2 * currSize - 1
                    int mid = Math.Min(left + currSize - 1, n - 1);

                    int right = Math.Min(left + 2 * currSize - 1, n - 1);

                    // Вызов метода для слияния двух подмассивов
                    Merge(arr, left, mid, right);
                }
            }
        }
    }
}
