//mohammad dehghani project

using System;
namespace project;
{
    class Test
    {
        public static void Main()
        {
            double[,] array = new double[50,50];
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.Write("element {0},{1} = ", i + 1, j + 1);
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Calc(array);
        }
        private static void Calc(double[,] array)
        {
            for (int i = 0; i < 48; i++)
            {
                for(int j = 0; j < 48; j++)
                {
                    array[i + 1, j + 1] = (array[i, j] + array[i, j + 1] +
                    array[i, j + 2] + array[i + 1, j] + array[i + 2, j] +
                    array[i + 2, j + 1] + array[i + 2, j + 2] + array[i + 1, j + 2])/8;
                }
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.WriteLine("new element {0},{1} = {2} ", i + 1, j + 1, array[i,j]);
                }
            }
        }
    }
}