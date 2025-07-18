﻿using System.Collections.Immutable;
using System.ComponentModel;
using System.IO.Pipelines;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
   
        static int SumOfIndividualDigits(string Digit)
        {
            int Sum = 0;
            for (int i = 0; i < Digit.Length; i++)
            {
                Sum += int.Parse(Digit[i].ToString());
            }
            return Sum;
        }
        static void SumAndSub(int X,int Y,out int Sum,out int Sub)
        {
            Sum = X + Y;
            Sub = X - Y;
        }
        static bool IsPrime(int Number)

        {
            if (Number == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(Number); i++)
            {
                if (Number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static string ChangeChar(string word,int position,char character)
        {
            if (position > word.Length||position <0)
            {
                return "Invalid position";
            }
            else
            {
                char[] WordChars = word.ToCharArray();
                WordChars[position] = character;
                return new string(WordChars);
            }
           
        }
        static void MinMaxArray(int[] Arr,ref int Min,ref int Max)
        {
            Min = Arr[0];
            Max = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                {
                    Min = Arr[i];
                }
                else if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
            }
        }
       
        //Q8
        static int FactoralOFNumber(int Number)
        {
            int Result = 1;
            for (int i = Number; i > 0; i--)
            {
                Result *= i;
            }
            return Result;
        }
        //Q9

       
        static int SumArray(int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        //Q10
        static int[][] DisplayIdentityMatrix(int N)
        {
            int[][] Matrix = new int[N][];
            for (int i = 0; i < N; i++)
            {
                Matrix[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Matrix[i][j] = 1;
                    }
                    else
                    {
                        Matrix[i][j] = 0;
                    }

                }

            }
            return Matrix;
        }
        //Q11
        static int[] MergeAndSortTwoArrays(int[] Arr1,int[] Arr2)
        {
            int[] Result = Arr1.Concat(Arr2).ToArray();
            Array.Sort(Result);
            return Result;
        }

        //Q12
        static void FindMaxAndMinInArray(int[] Arr)
        {
            int Min = Arr[0], Max = Arr[0];
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                {
                    Min = Arr[i];
                }
                else if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
               
            }
            Console.WriteLine($"Max={Max}");
            Console.WriteLine($"Min={Min}");
        }
        
        //Q13
        static int FindSecondLargestNumber(int[] Arr)
        {
            int First = Arr[0], Second = Arr[0];

            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] > First)
                {
                    Second = First;
                    First = Arr[i];
                }
                else if (Arr[i] > Second && Arr[i]!=First)
                {
                    Second = Arr[i];
                }
            }
            return Second;
        }
       
        //Q14
        static int FindMaxDistanceBetweenTwoEqualCells(int[] Arr)
        {
            int MaxDistance = 0;
            for (int i = 0; i < Arr.Length-1; i++)
            {
                for (int j = Arr.Length-1; j > i; j--)
                {
                    if (Arr[i] == Arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > MaxDistance)
                        {
                            MaxDistance = distance;
                        }
                            break;
                    }
                }
            }
            return MaxDistance;
        }
       
        //Q15
        static string ReverseString(string[] Arr)
        {
            
             Array.Reverse(Arr);
            return string.Join(" ", Arr);
        }
      
        //Q16
        static int[][] CopyArray(int[][] Arr,int N01)
        {
            int[][] Second = new int[N01][];

            for (int i = 0; i < N01; i++)
            {
                Second[i] = new int[Arr[i].Length];
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Second[i][j] = Arr[i][j];
                }
            }
            return Second;
        }
       
        //Q17
        static int[] ReverseArray(int[] Arr)
        {
            int[] ReversedArray=new int[Arr.Length];
            int j = 0;
            for (int i = Arr.Length-1; i >=0 ; i--)
            {
                ReversedArray[j]=Arr[i];
                j++;
            }
            return ReversedArray;
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

            //SumAndSub(3,5,out int Sum, out int Sub);

            //Console.WriteLine($"Sum={Sum}");
            //Console.WriteLine($"Subtraction={Sub}");

            #endregion

            #region Q4
            /*
             4- Write a program in C# Sharp to create a function to calculate the sum of the 
                 individual digits of a given number. 
             */
            //Console.Write("Enter a number: ");
            //string Digit = Console.ReadLine();
            //Console.WriteLine($"The sum of the digits of the number {Digit} is: {SumOfIndividualDigits(Digit)} ");
            #endregion

            #region Q5
            // 5 - Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not: 
            //Console.Write("Enter a Number: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(IsPrime(Number));
            #endregion

            #region Q6
            /*
             6- Create a function named MinMaxArray, to return the minimum and 
                 maximum values stored in an array, using reference parameters 
             */
            //int Min = 0, Max = 0;
            //int[] Numbers = { 1, 2, 3,-2, 4, 5 };
            //MinMaxArray(Numbers, ref Min, ref Max);
            //Console.WriteLine($"Max={Max}");
            //Console.WriteLine($"Min={Min}");
            #endregion

            #region Q7
            /*
              Create function to calculate the factorial of the number specified as 
              parameter 
             */
            //Console.Write("Enter a Number: ");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Result= {FactoralOFNumber(Number)}");
            #endregion

            #region Q8
            /*
             8- Create a function named "ChangeChar" to modify a letter in a certain 
                position (0 based) of a string, replacing it with a different letter  
             */
            //Console.Write("Enter the Word: ");
            //string Word = Console.ReadLine();
            //Console.Write("Enter the position: ");
            //int position = int.Parse(Console.ReadLine());
            //Console.Write("Enter the letter: ");
            //char letter = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Word is: {ChangeChar(Word,position,letter)}"); ;
            #endregion

            #region Q9
            /*
             9- . Write a program that prints an identity matrix using for loop, in 
                  other words takes a value n from the user and shows the identity table 
                  of size n * n. 
             */
            //Console.Write("Enter size of array: ");
            //int N = int.Parse(Console.ReadLine());
            //int[][] Matrix = DisplayIdentityMatrix(N);
            //for (int i = 0; i < N; i++)
            //{
            //    for ( int j = 0; j < N; j++)
            //    {
            //        Console.Write(Matrix[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q10
            /*
             10- Write a program in C# Sharp to find the sum of all elements of the 
                 array.
             */
            //int[] Arr = { 3, 4, 5 };
            //Console.WriteLine($"Sum= {SumArray(Arr)} ");
            #endregion


            #region Q11
            /*
             11- - Write a program in C# Sharp to merge two arrays of the same size 
                    sorted in ascending order. 
             */
            int[] Arr1 = { 103, 6, 0 };
            //int[] Arr2 = { 3, 9, 100 };
            //int[] Result = MergeAndSortTwoArrays(Arr1, Arr2);
            //for (int i = 0; i < Result.Length; i++)
            //{
            //    Console.Write($"{Result[i]} ");  
            //}
            #endregion


            #region Q12
            /*
             12- Write a program in C# Sharp to find maximum and minimum element in an 
                  array
             */
            //int[] Numbers = { 1, 5, 100, -5, 20 };
            //FindMaxAndMinInArray(Numbers);
            #endregion


            #region Q13
            /*
             13- Write a program in C# Sharp to find the second largest element in an 
                 array. 
             */
            //int[] Numbers = { 1, 2, 3, 4, 9, 10, 5 };
            //Console.WriteLine(FindSecondLargestNumber(Numbers));
            #endregion

            #region Q14
            /*
             write a program to find the longest distance between Two equal cells. In this example. The 
            distance is measured by the number Of cells- for example, the distance between the first and the 
            fourth cell is 2 (cell 2 and cell 3). 
             */
            //Console.Write("Enter the size of the array: ");
            //int Size = int.Parse(Console.ReadLine());
            //int[] Arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Arr[{i}]= ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Max distance is {FindMaxDistanceBetweenTwoEqualCells(Arr)}");
            #endregion

            #region Q15
            //Console.Write("Enter the text: ");
            //string Text = Console.ReadLine();
            //string[] Arr = Text.Split(" ");
            //Console.WriteLine($"Reversed string={ReverseString(Arr)}");

            #endregion

            #region Q16
            /*
             16- Write a program to create two multidimensional arrays of same size. 
                Accept values from the user and store them in first array. Now copy all 
               the elements of the first array on second array and print second array. 
             */
            //Console.Write("Enter the first dimension size: ");
            //int N01 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the Second dimension size: ");
            //int N02 = int.Parse(Console.ReadLine());
            //int[][] First = new int[N01][];
            //Console.WriteLine("Enter array elements: ");
            //for (int i = 0; i < N01; i++)
            //{
            //    First[i] = new int[N02];
            //    for (int j = 0; j < N02; j++)
            //    {
            //        First[i][j] = int.Parse(Console.ReadLine());   
            //    }
            //}
            //int[][] Second = CopyArray(First, N01);
            //Console.WriteLine("Copied array");
            //for (int i = 0; i < N01; i++)
            //{       
            //    for (int j = 0; j < Second[i].Length; j++)
            //    {
            //        Console.Write($"{Second[i][j]} ");   
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q17
            /*
             17- Write a Program to Print One Dimensional Array in Reverse Order 
             */
            Console.Write("Enter array size: ");
            int N = int.Parse(Console.ReadLine());
            int[] Arr = new int[N];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < N; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            int [] ReversedArray= ReverseArray(Arr);
            Console.WriteLine("Reversed array: ");
            for (int i = 0; i < ReversedArray.Length; i++)
            {
                Console.Write($"{ReversedArray[i]} ");
            }
            #endregion
        }


    }
}
