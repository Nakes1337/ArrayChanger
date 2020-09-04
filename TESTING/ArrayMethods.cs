using System;

namespace TESTING
{
    internal class ArrayMethods 
    {
        public static int[] ArrayGenerating(int ArraySize)
        {
            Random rnd = new Random();
            int[] array = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            return array;
        }
        public static int[] ArrayCBSA(int[] array) //Changes based on the specified attribute
        {
            Console.WriteLine($"С чем будут осуществляться действия: " +
                $"\n (1) => Элемент массива " +
                $"\n (2) => Массив " +
                $"\n (3) => Сортировка");
            string Operation = Console.ReadLine();
            if (Operation == "1" | Operation == "элемент массива" | Operation == "Элемент массива")
            {
                return SpecifiedAttribute.ChangeElement(array);
            }
            else if (Operation == "2" | Operation == "массив" | Operation == "Массив")
            {
                return SpecifiedAttribute.ChangeArray(array);
            }
            else if (Operation == "3" | Operation == "Сортировка" | Operation == "сортировка")
            {
                Console.WriteLine("Какой тип сортировки осуществить ?" +
                    "\n (1) => От большего к меньшему " +
                    "\n (2) => От меньшего к большему");
                Operation = Console.ReadLine();
                if (Operation == "1")
                {
                    return SpecifiedAttribute.MaxToMin(array);
                }
                else
                {
                    return SpecifiedAttribute.MinToMax(array);
                }
            }
            else
            {
                Console.WriteLine("Введены некоректные данные");
                return array;
            }
        }
    }
}
