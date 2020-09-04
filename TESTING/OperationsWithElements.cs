using System;

namespace TESTING
{
    internal class OperationsWithElements
    {
        internal static int[] PlusOperator(int[] array, int element)
        {
            Console.WriteLine("На сколько ?");
            int chng = int.Parse(Console.ReadLine());
            array[element] += chng;
            return array;
        }
        internal static int[] MinusOperator(int[] array, int element)
        {
            Console.WriteLine("На сколько ?");
            int chng = int.Parse(Console.ReadLine());
            array[element] -= chng;
            return array;
        }
        internal static int[] DeleteOperator(int[] array, int element)
        {
            int[] NewArray = new  int[(array.Length - 1)];
            for (int i = 0; i < NewArray.Length; i++)
            {
                if (i >= element)
                {
                    NewArray[i] = array[i+1];
                }
                else
                {
                    NewArray[i] = array[i];
                }
            }
            array = NewArray;
            return array;
        }
        internal static int[] AddOperator(int[] array, int elementPos, int newElement)
        {
            int[] NewArray = new int[(array.Length + 1)];
            NewArray[elementPos] = newElement;
            for (int i = 0; i < elementPos; i++)
            {
                NewArray[i] = array[i];
            }
            for (int i = elementPos; i < array.Length; i++)
            {
                NewArray[i + 1] = array[i];
            }
            array = NewArray;
            return array;
        }
    }
}
