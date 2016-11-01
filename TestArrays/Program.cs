using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Sum = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                Sum += array2[i];
                // Sum = Sum + array2[i]; 
            }

            for (int i = array2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array2[i]);
            }


            int Min = array2[0];
            int Max = array2[0];
            for (int i = 1; i < array2.Length; i++)
            {
                if (array2[i] < Min)
                    Min = array2[i];

                if (array2[i] > Max)
                    Max = array2[i];
            }



            int Size = int.Parse(Console.ReadLine());

            int[] array3 = new int[Size];


            int x = 0;
            foreach (int Element in array2)
            {
                Console.WriteLine(Element);
                x = Element + 1;
            }




        }
    }
}
