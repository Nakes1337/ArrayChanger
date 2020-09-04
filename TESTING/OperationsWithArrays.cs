using System;

namespace TESTING
{
    internal class OperationsWithArrays
    {
        internal static int[] PlusOperator(int[] array)
        {
            Console.WriteLine("На сколько ?");
            int chng = int.Parse(Console.ReadLine());
            for (int element = 0; element < array.Length; element++)
            {
                array[element] += chng;
            }
            return array;
        }
        internal static int[] MinusOperator(int[] array)
        {
            Console.WriteLine("На сколько ?");
            int chng = int.Parse(Console.ReadLine());
            for (int element = 0; element < array.Length; element++)
            {
                array[element] -= chng;
            }
            return array;
        }
    }
}