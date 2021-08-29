using System;

namespace MultiDimiensionArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            int c = 0;
            Console.WriteLine("Enter the row size of Array :");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the colomn size of Array :");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[,] Arr1 = new int[size1, size2];
            for (r = 0; r <= size1 - 1; r++)
            {
                for (c = 0; c <= size2 - 1; c++)
                {
                    Console.WriteLine("Enter the [" + r + "," + c + "]  in 1st Array :");
                    Arr1[r, c] = Convert.ToInt32(Console.ReadLine());
                }

            }
            int[,] Arr2 = new int[size1, size2];
            for (r = 0; r <= size1 - 1; r++)
            {
                for (c = 0; c <= size2 - 1; c++)
                {
                    Console.WriteLine("Enter the [" + r + "," + c + "]  in 2ND Array :");
                    Arr2[r, c] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.Write("\nFirst matrix is:\n");
            for (r = 0; r <= size1 - 1; r++)
            {
                Console.Write("\n");
                for (c = 0; c <= size2 - 1; c++)
                {
                    Console.Write("{0}\t", Arr1[r, c]);
                }

            }
            Console.Write("\n\n");
            Console.Write("\nSecond matrix is:\n");
            for (r = 0; r <= size1 - 1; r++)
            {
                Console.Write("\n");
                for (c = 0; c <= size2 - 1; c++)
                {
                    Console.Write("{0}\t", Arr2[r, c]);
                }

            }
            Console.Write("\n\n");
            MatrixMultiplication mm = new MatrixMultiplication();
            //mm.printAddition(Arr1,Arr2);
            mm.Multiplication(Arr1, Arr2, size1, size2);


        }
    }
    public class MatrixMultiplication
    {
        int r;
        int c;
        int siz1;
        int siz2;
        public void Multiplication(int[,] arr1, int[,] arr2, int size1, int size2)
        {
            siz1 = size1;
            siz2 = size2;
            int[,] arr3 = new int[siz1, siz2];
            for (r = 0; r <= siz1 - 1; r++)
            {
                for (c = 0; c <= siz2 - 1; c++)
                {
                    arr3[r, c] = 0;
                    for(int k = 0; k<=siz2-1;k++)
                    {
                        arr3[r, c] += arr1[r, k] * arr2[k, c];
                    }
                    
                }
            }
            Console.Write("\nMultiplication two matrices: \n");
            for (r = 0; r <= siz1 - 1; r++)
            {
                Console.Write("\n");
                for (c = 0; c <= siz2 - 1; c++)
                {
                    Console.Write("{0}\t", arr3[r, c]);
                }
                    
            }
            Console.Write("\n\n");
        }
        //public void printAddition(int[,] arr1, int[,] arr2)
        //{
        //    for (r = 0; r <= siz1 - 1; r++)
        //    {
        //        Console.Write("\n");
        //        for (c = 0; c <= siz2 - 1; c++)
        //        {
        //            Console.Write("{0}\t", arr1[r, c]);
        //        }

        //    }
        //    Console.Write("\n\n");
        //    Console.Write("\nSecond matrix is:\n");
        //    for (r = 0; r <= siz1 - 1; r++)
        //    {
        //        Console.Write("\n");
        //        for (c = 0; c <= siz2 - 1; c++)
        //        {
        //            Console.Write("{0}\t", arr2[r, c]);
        //        }

        //    }
        //    Console.Write("\n\n");

        //}

    }
}
