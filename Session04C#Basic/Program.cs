using System.Runtime.InteropServices;
using System.Text;

namespace Session04C_Basic
{
    //1.Struct->Function
    //2.Interfaces-->Function
    //3.Classes -->Function
    //4.Enum

    internal class Program
    {
        //static void PrintShape()
        //   {
        //       for (int i = 0; i < 10; i++)
        //       {
        //           Console.WriteLine("^-^");

        //       }
        //   }
        //static void PrintShape(int Count)
        //   {
        //       for (int i = 0; i < Count; i++)
        //       {
        //           Console.WriteLine("^-^");

        //       }
        //   }

        static void PrintShape(string Pattern = "XXX-", int Count = 4)
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Pattern);

            }
        }

        static int SumNumbers(int Number01, int Number02)
        {
            return Number01 + Number02;
        }

        //static void SWAP(int X,int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //static void SWAP(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}




        static void Main(string[] args)
        {
            #region One D Array Video01
            //int[] Numbers;
            //Declare for a reference (Pointer) from type "Array of integer"
            //Numbers:Can refer to object of type  "Array of integer"
            //Numbers :Refer to null

            //8Bytes will be allocated at  STACK for reference Numbers
            //0 Bytes will be allocated at HEAP

            //Numbers = new int[5];
            //new
            //1.Allocate the required bytes for the object at HEAP (5*4=>20bytes)
            //2.Initialze the allocated bytes with the default value of datatype
            //3.calls user defined constructor if exist
            //4.Assign the object for the reference "Numbers"

            //Console.WriteLine(Numbers[0]);
            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 11;
            //Numbers[4] = 19;
            //Numbers[5] = 20; //Out of range
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine( Numbers[1]);
            //Console.WriteLine( Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] Numbers02 = new int[6] { 1, 2, 3, 4, 5, 6 };
            //int[] Numbers03 = { 1, 2, 3, 4 };
            //int[] Numbers04 = new int[6];

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"Enter Numbers[{i}]: ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("====================================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.Write($"{Numbers[i]} ");
            //}

            //Console.WriteLine(Numbers.Length);//Return the size of the array
            //Console.WriteLine(Numbers.Rank);//Return the dimension if array like 1D 2D---
            //Console.WriteLine(Numbers);
            //Console.WriteLine(Numbers.GetType()); 
            #endregion

            #region Two D Array Video02
            //int[,] Marks = new int[3, 3];
            //Marks[0, 0] = 99;
            //Marks[0, 1] = 99;
            //Marks[0, 2] = 99;

            //Marks[1, 0] = 80;
            //Marks[1, 1] = 98;
            //Marks[1, 2] = 97;

            //Marks[2, 0] = 88;
            //Marks[2, 1] = 89;
            //Marks[2, 2] = 47;

            //Console.WriteLine(Marks[0, 0]);
            //Console.WriteLine(Marks[0, 1]);
            //Console.WriteLine(Marks[0, 2]);
            //Console.WriteLine(Marks[1, 0]);
            //Console.WriteLine(Marks[1, 1]);
            //Console.WriteLine(Marks[1, 2]);
            //Console.WriteLine(Marks[2, 0]);
            //Console.WriteLine(Marks[2, 1]);
            //Console.WriteLine(Marks[2, 2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Mark[{i},{j}]: ");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }

            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

        }
    }
}
