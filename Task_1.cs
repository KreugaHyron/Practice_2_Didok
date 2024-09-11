using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practice_2_Didok
{
    public interface IOutput
    {
        void Show(); 
        void Show(string info);
    }
    public class Array : IOutput
    {
        private int[] array;
        public Array(int size)
        {
            array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
            }
        }

        internal static void Sort(int[] array)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            Console.WriteLine("Елементи масиву:");
            foreach (int element in array)
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
    }
}
