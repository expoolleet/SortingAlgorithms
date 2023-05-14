namespace SortingAlgorithms.Algorithms
{
    internal class Sorting
    {
        public static void StupidSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    var temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = 0;
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
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
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
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                left++;
                for (int i = right - left - 1; i > left; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        var temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
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
                    var temp = array[i];
                    array[i] = array[i - 1];
                    array[i - 1] = temp;
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
                var temp = array[min_index];
                array[min_index] = array[i];
                array[i] = temp;
            }          
        }

        public static void ShellSort(int[] array)
        {
            int d = array.Length;
            while(d > 0)
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
    }
}
