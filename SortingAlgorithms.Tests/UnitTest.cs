using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms.Algorithms;
using System;

namespace SortingAlgorithms.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Properly_Sorted_Array_StupidSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.StupidSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_BubbleSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.BubbleSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_CocktailSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.CocktailSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_InsertionSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.InsertionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_GnomeSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.GnomeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_SelectionSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.SelectionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_ShellSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.ShellSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_QuickSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.QuickSort(test_array, 0, test_array.Length - 1);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Properly_Sorted_Array_MergeSort()
        {
            //arrange
            int[] array = { 64, 34, -25, 12, 0, 22, -11, 90};
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.MergeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_StupidSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.StupidSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_BubbleSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.BubbleSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_CocktailSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.CocktailSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_InsertionSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.InsertionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_GnomeSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.GnomeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_SelectionSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.SelectionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_ShellSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.ShellSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void Equal_Elements_In_Array_QuickSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.QuickSort(test_array, 0, test_array.Length-1);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }
        [TestMethod]
        public void Equal_Elements_In_Array_MergeSort()
        {
            //arrange
            int[] array = { 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.MergeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_StupidSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.StupidSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_BubbleSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.BubbleSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_CocktailSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.CocktailSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_InsertionSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.InsertionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_GnomeSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.GnomeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_SelectionSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.SelectionSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_ShellSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.ShellSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_QuickSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.QuickSort(test_array, 0, array.Length - 1);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }

        [TestMethod]
        public void One_Element_In_Array_MergeSort()
        {
            //arrange
            int[] array = { 1 };
            int[] test_array = new int[array.Length];
            Array.Copy(array, test_array, array.Length);
            Array.Sort(array);

            //act
            Sorting.MergeSort(test_array);

            //assert
            CollectionAssert.AreEqual(array, test_array);
        }
    }
}
