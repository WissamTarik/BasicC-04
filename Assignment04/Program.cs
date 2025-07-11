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
        static int SumArrayByValue(int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 100, 200 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i]; 
            }
            return Sum;
        }
        static int SumArrayByReference(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 100, 200 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i]; 
            }
            return Sum;
        }

        static void SumAndSub(int X,int Y,out int Sum,out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) 
            //by value and by reference then write a suitable c# example. 

            //Passing by value Means copying the  value in STACK FRAME of function
            //and the actual value isn't affected by any change
            //int A = 10, B = 15;
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

            //Console.WriteLine("====Before Swapping=====");
            //Console.WriteLine($"A= {A}");//10
            //Console.WriteLine($"B= {B}");//15
            //SwapByReference(ref A,ref B);

            //Console.WriteLine();
            //Console.WriteLine("====After Swapping=====");
            //Console.WriteLine($"A= {A}");//15
            //Console.WriteLine($"B= {B}");//10
            #endregion

            #region Q2
            /*
              Explain the difference between passing (Reference type 
              parameters) by value and by reference then write a suitable c# 
              example. 
             */

            //Passing by value
            //We pass a copy of the reference if we changed the value in function will affect
            //the actual variable  but when we re-assign the parameters to new object it doesn't
            //affect the outer value will still point to it
            //the old value will still reachable by outside variables
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine($"Total={SumArrayByValue(Numbers)}");
            //Console.WriteLine($"Numbers[0]={Numbers[0]}");

            //Passing by reference
            //we use ref Keyword
            //when we re-assign the parameters to new value it will affect the actual value
            // the old value will be unreachable
            //Console.WriteLine($"Total={SumArrayByReference(ref Numbers)}");
            //Console.WriteLine($"Numbers[0]={Numbers[0]}");
            #endregion

            #region Q3

            //3 - Write a c# Function that accept 4 parameters from user and 
            //return result of summation and subtracting of two numbers

            SumAndSub(3,5,out int Sum, out int Sub);

            Console.WriteLine($"Sum={Sum}");
            Console.WriteLine($"Subtraction={Sub}");

            #endregion
        }
    }
}
