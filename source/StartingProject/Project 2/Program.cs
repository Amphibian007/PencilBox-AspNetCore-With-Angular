using System;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4, 5, 6};
            int[] arr2 = { 3, 9, 8 };
            int[] arr3 = { 4, 11, 10};
            var myArray= MiddleElementArray(arr1, arr2, arr3);
            Console.WriteLine(string.Join(',',myArray));
        }
        public static int[] MiddleElementArray(int[] arr1, int[] arr2, int[] arr3)
        {
            int length = (int)Math.Floor((double)arr1.Length / 2);
            int[] newArray = new int[3];
            newArray[0] = arr1[length];
            newArray[1] = arr2[length];
            newArray[2] = arr3[length];
            return newArray;
        }
    }
}
