using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TESTING
{
    internal class SpecifiedAttribute
    {
        internal static int[] ChangeElement(int[] array) //Changes based on the specified attribute for Element
        {
            Console.WriteLine("Какой элемент массива вы хотите изменить ?");
            int element = int.Parse(Console.ReadLine());
            if (element < 0 | element > array.Length)
            {
                Console.WriteLine("Выбран несуществующий элемент");
                return array;
            }      
            Console.WriteLine("Что вы хотите сделать с элементом ?" +
                " \n (1) => Увеличить" +
                " \n (2) => Уменьшить");
            string Operation = Console.ReadLine();
            if (Operation == "1" | Operation == "Увеличить" | Operation == "Увеличить")
            {
                return OperationsWithElements.PlusOperator(array, element);
            }
            else if (Operation == "2" | Operation == "Уменьшить" | Operation == "уменьшить")
            {
                return OperationsWithElements.MinusOperator(array, element);
            }
            else
            {
                Console.WriteLine("Выбрана неверная операция");
                return array;
            }
        }
        internal static int[] ChangeArray(int[] array) //Changes based on the specified attribute for Array
        {
            Console.WriteLine("Что вы хотите сделать с массивом ?" +
                " \n (1) => Увеличить элементы" +
                " \n (2) => Уменьшить элементы");
            string Operation = Console.ReadLine();
            if (Operation == "1" | Operation == "Увеличить элементы" | Operation == "Увеличить элементы")
            {
                return OperationsWithArrays.PlusOperator(array);
            }
            else if (Operation == "2" | Operation == "Уменьшить элементы" | Operation == "уменьшить элементы")
            {
                return OperationsWithArrays.MinusOperator(array);
            }
            else
            {
                Console.WriteLine("Выбрана неверная операция");
                return array;
            }
        }
        internal static int[] MinToMax(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int timeOp = array[i];
                        array[i] = array[j];
                        array[j] = timeOp;
                    }
                }
            }
            return array;
        }
        internal static int[] MaxToMin(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int timeOp = array[i];
                        array[i] = array[j];
                        array[j] = timeOp;
                    }
                }
            }
            return array;
        }
    }
}
