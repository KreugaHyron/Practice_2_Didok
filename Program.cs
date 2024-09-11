using System;
namespace Practice_2_Didok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1
            Console.WriteLine("Task_1: ");
            Console.ReadKey();

            Array myArray = new Array(10);

            myArray.Show();
            myArray.Show("Виведення масиву:");

            Console.WriteLine();
            Console.ReadKey();
            //Task_2
            Console.WriteLine("Task_2: ");
            Console.ReadKey();
            Array_1 myArray_1 = new Array_1(10);

            myArray_1.Show();
            myArray_1.Show("Виведення масиву:");

            Console.WriteLine("Максимум: " + myArray_1.Max());
            Console.WriteLine("Мінімум: " + myArray_1.Min());
            Console.WriteLine("Середнє арифметичне: " + myArray_1.Avg());

            int valueToSearch = 50;
            Console.WriteLine($"Шукаємо значення {valueToSearch} у масиві: " + (myArray_1.Search(valueToSearch) ? "Знайдено" : "Не знайдено"));
            Console.WriteLine();
            Console.ReadKey();
            //Task_3
            Console.WriteLine("Task_3: ");
            Console.ReadKey();
            Array_2 myArray_2 = new Array_2(10);
            myArray_2.Show();
            myArray_2.Show("Виведення масиву:");

            Console.WriteLine("Максимум: " + myArray_2.Max());
            Console.WriteLine("Мінімум: " + myArray_2.Min());
            Console.WriteLine("Середнє арифметичне: " + myArray_2.Avg());

            int valueToSearch_1 = 50;
            Console.WriteLine($"Шукаємо значення {valueToSearch} у масиві: " + (myArray_2.Search(valueToSearch) ? "Знайдено" : "Не знайдено"));
            myArray_2.SortAsc();
            myArray_2.Show("Масив відсортований за зростанням:");

            myArray_2.SortDesc();
            myArray_2.Show("Масив відсортований за спаданням:");

            myArray_2.SortByParam(true);  
            myArray_2.Show("Масив відсортований за зростанням через SortByParam:");

            myArray_2.SortByParam(false);  
            myArray_2.Show("Масив відсортований за спаданням через SortByParam:");

            Array_2 myArray_3 = new Array_2(10);
            Console.WriteLine("Порівняння двох масивів за максимальним елементом:");
            int comparisonResult = myArray_2.CompareTo(myArray_3);
            if (comparisonResult > 0)
            {
                Console.WriteLine("Перший масив має більший максимум.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Другий масив має більший максимум.");
            }
            else
            {
                Console.WriteLine("Максимуми обох масивів однакові.");
            }
            Console.ReadKey();
        }
    }
}
