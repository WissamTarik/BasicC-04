using System.ComponentModel;

namespace Assignment04
{
    internal class Program
    {
        //Swap the value of two inputs
        static void SwapByValue(int X,int Y)
        {
            int Temp = X;
            X = Y;
            Y=Temp;

        }
        static void SwapByReference(ref int  X,ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) 
            //by value and by reference then write a suitable c# example. 

            //Passing by value Means copying the  value in STACK FRAME of function
            //and the actual value isn't affected by any change
            int A = 10, B = 15;
            //Console.WriteLine("====Before Swapping=====");
            //Console.WriteLine($"A= {A}");//10
            //Console.WriteLine($"B= {B}");//15
            //SwapByValue(A, B);
            //Console.WriteLine();
            //Console.WriteLine("====After Swapping=====");
            //Console.WriteLine($"A= {A}");//10
            //Console.WriteLine($"B= {B}");//15

            //Passing by refrenece Means passing the addresses of variables to the function
            //which mean any change will affect the actual value of variables
            //(Makes the parameters and variables refer to same space in stack)
            //by using ref Keyword

            Console.WriteLine("====Before Swapping=====");
            Console.WriteLine($"A= {A}");//10
            Console.WriteLine($"B= {B}");//15
            SwapByReference(ref A,ref B);

            Console.WriteLine();
            Console.WriteLine("====After Swapping=====");
            Console.WriteLine($"A= {A}");//15
            Console.WriteLine($"B= {B}");//10
            #endregion
        }
    }
}
