using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practice_2_Didok
{
    public interface IOutput_2
    {
        void Show();
        void Show(string info);
    }

    public interface IMath_1
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    public interface ISort
    {
        void SortAsc();    
        void SortDesc();  
        void SortByParam(bool isAsc);  
    }

    public class Array_2 : IOutput_2, IMath_1, ISort, IComparable<Array_2>
    {
        private int[] __array;

        public Array_2(int size)
        {
            __array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < __array.Length; i++)
            {
                __array[i] = rand.Next(1, 101);
            }
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in __array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }

        public int Max()
        {
            int max = __array[0];
            foreach (int element in __array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = __array.Length > 0 ? __array[0] : 0;
            foreach (int element in __array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int element in __array)
            {
                sum += element;
            }
            return (float)sum / __array.Length;
        }

        public bool Search(int valueToSearch_1)
        {
            foreach (int element in __array)
            {
                if (element == valueToSearch_1)
                {
                    return true;
                }
            }
            return false;
        }
        static void Sort(int[] __array)
        {
            throw new NotImplementedException();
        }
        static void Reverse(int[] __array)
        {
            throw new NotImplementedException();
        }
        public void SortAsc()
        {
            Array_2.Sort(__array);  
        }

        public void SortDesc()
        {
            Array_2.Sort(__array);    
            Array_2.Reverse(__array); 
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();  
            }
            else
            {
                SortDesc(); 
            }
        }
        public int CompareTo(Array_2 other)
        {
            return this.Max().CompareTo(other.Max());
        }
    }
}
