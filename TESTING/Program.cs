using System;

namespace TESTING
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива: ");
            int ArrayLength = int.Parse(Console.ReadLine());
            var array = ArrayMethods.ArrayGenerating(ArrayLength); // Происходит генерация массива с использованием рандомайзера;
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine($"{i} элемент массива == {array[i]}");
            }
            bool EndProg = false;
            while (EndProg == false)
            {   

                Console.WriteLine("Выберите нужную вам операцию: " +
                    "\n (1) => Изменить массив " +
                    "\n (2) => Вывести массив " +
                    "\n (3) => Сгенерировать новый массив " +
                    "\n (4) => Удалить элемент " +
                    "\n (5) => Добавить элемент " +
                    "\n (6) => Закончить редактирование массива");
                string Operation = Console.ReadLine();
                if (Operation == "Изменить массив" | Operation == "изменить массив" | Operation == "1")
                {
                    ArrayMethods.ArrayCBSA(array);
                }
                else if (Operation == "Вывести массив" | Operation == "вывести массив" | Operation == "2")
                {
                    for (int i = 0; i < ArrayLength; i++)
                    {
                        Console.WriteLine($"{i} элемент массива == {array[i]}");
                    }
                }
                else if (Operation == "Сгенерировать новый массив" | Operation == "сгенерировать новый массив" | Operation == "3" )
                {
                    Console.WriteLine("Хотите изменить размерность массива ? " +
                        "\n (1) => Да" +
                        "\n (2) => Нет");
                    string func = Console.ReadLine();
                    if (func == "Да" | func == "да" | func == "1")
                    { 
                        Console.WriteLine("Введите новую размерность массива");
                        int ArrayNewLength = int.Parse(Console.ReadLine());
                        array = ArrayMethods.ArrayGenerating(ArrayNewLength);
                        ArrayLength = ArrayNewLength;
                    }
                    else if (func == "Нет" | func == "нет" | func == "2")
                    {
                        array = ArrayMethods.ArrayGenerating(ArrayLength);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка идентификации ответа");
                    }
                }
                else if (Operation == "Удалить элемент" | Operation == "удалить элемент" | Operation == "4")
                {
                    Console.WriteLine("Введите какой элемент вы хотите удалить ");
                    int element = int.Parse(Console.ReadLine());
                    if (element > 0 | element < array.Length)
                    {
                      array = OperationsWithElements.DeleteOperator(array, element);
                        ArrayLength--;
                    }
                    else
                    {
                        Console.WriteLine("Такого элемента нет в массиве");
                    }
                }
                else if (Operation == "Добавить элемент" | Operation == "добавить элемент" | Operation == "5")
                {
                    Console.WriteLine("Какой элемент вы хотите добавить ?");
                    int newElement = int.Parse(Console.ReadLine());
                    Console.WriteLine("Укажите на какое место вы хотите его добавить ");
                    int elementPos = int.Parse(Console.ReadLine());
                    if (elementPos > 0 | elementPos < array.Length)
                    {
                        array = OperationsWithElements.AddOperator(array, elementPos, newElement);
                        ArrayLength++;
                    }
                    else
                    {
                        Console.WriteLine("Отсутствует такая возможность");
                    }
                }
                else if (Operation == "Закончить редактирование массива" | Operation == "закончить редактирование массива" | Operation == "6")
                {
                    EndProg = true;
                }
                else
                {
                    Console.WriteLine("Введена неизвестная операция");
                }
                Console.WriteLine("--------------------------------");
            }
        }
    }
}
