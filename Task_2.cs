using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2_Didok
{
    public interface IOutput_1
    {
        void Show(); 
        void Show(string info); 
    }

    public interface IMath
    {
        int Max(); 
        int Min(); 
        float Avg(); 
        bool Search(int valueToSearch); 
    }

    public class Array_1 : IOutput_1, IMath
    {
        private int[] _array;
        public Array_1(int size)
        {
            _array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(1, 101); 
            }
        }
        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in _array)
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
            int max = _array[0]; 
            foreach (int element in _array)
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
            int min = _array.Length > 0 ? _array[0] : 0;
            foreach (int element in _array)
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
            foreach (int element in _array)
            {
                sum += element;
            }
            return (float)sum / _array.Length;
        }
        public bool Search(int valueToSearch)
        {
            foreach (int element in _array)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
