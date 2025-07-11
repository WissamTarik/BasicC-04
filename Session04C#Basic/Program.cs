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

        }
    }
}
