using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Ass5Csharp
{
    internal class Program
    {
        #region Q1
        ////q1:Explain the difference between passing (Value type parameters) by value and by reference
        ////then write a suitable c# example.

        //// Answer:
        //// Value type parameters by value
        //// we are passing a copy of the variable to the mwthod so if we change any thing in the method the original variable not be changed
        ////Example:
        //static void SumByValue(int x , int y)
        //{
        //  int sum = x + y;
        //    Console.WriteLine($"Sum of {x} and {y} is : {sum}");
        //    x = 5; // this change will not affect the original variable
        //}
        //// Value type parameters by Ref
        //// we are passing the orginal variable to the mwthod so if we change any thing in the method the original variable will be changed
        ////Example:
        //static void SumByRef(ref int x,ref int y)
        //{
        //    x = 5; 
        //    int sum = x + y;
        //    Console.WriteLine($"Sum of {x} and {y} is : {sum}");
        //    // this change will not affect the original variable
        //}
        #endregion

        #region Q2
        //q2:Explain the difference between passing (Reference type parameters) by value and by reference
        ////then write a suitable c# example.
        //// Answer:
        //// Reference type parameters by value
        //// when we pass a reference we are passing a copy of the address of the variable to the method so we can't change the address of the variable but we can change the value of the variable
        //// Example:
        //static int SumArrayByValue(int[] arr)
        //{
        //    int Sum = 0;
        //    arr = [1, 2, 3];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Sum += arr[i];
        //    }
        //    return Sum;
        //}
        //// Reference type parameters by Ref
        //// when we pass a reference we are passing orginal of the address of the variable to the method so we can change the address of the variable but we can change the value of the variable
        //// Example:
        //static int SumArrayByRef(ref int[] arr)
        //{
        //    int Sum = 0;
        //    arr = [1, 2, 3];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Sum += arr[i];
        //    }
        //    return Sum;
        //}
        #endregion

        #region Q3 
        ////q3:Write a c# Function that accept 4 parameters from user and
        ////return result of summation and subtracting of two numbers
        //static void Sum_SubFun(int a, int b , out int Sum , out int sub)
        //{
        //    Sum = a + b;
        //    sub = a - b;
        //}

        #endregion

        #region Q4
        ////q4:Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //static void SumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while(num !=0)
        //    {
        //        int digit = num % 10;
        //        sum+= digit;
        //        num /= 10;
        //    }
        //    Console.WriteLine($"Sum of digits is : {sum}");
        //}


        #endregion

        #region Q5
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) return false;
        //    for(int i =2;i*i<=num;i++)
        //    {
        //          if (num % i == 0) 
        //            return false;
        //    }
        //    return true;
        //}
        #endregion

        #region Q6
        //static void MinMaxArray(int[]Arr)
        //{
        //    int max = Arr[0];
        //    int min = Arr[0];
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        if (Arr[i]>max)
        //            max= Arr[i];
        //        if (Arr[i]<min)
        //            min = Arr[i];
        //    }
        //}
        #endregion

        #region Q7
        //static void Factorial(int num)
        //{
        //    int fact = 1;
        //    for (int i = 1; i <= num; i++)
        //        fact *= i;

        //    Console.WriteLine($"Factorial of {num} is : {fact}");

        //}
        #endregion

        #region Q8
        //static string ChangeChar(string word, int position,char newChar)
        //{
        //    if (position < 0 || position >= word.Length)
        //    {
        //        Console.WriteLine("Position is out of range.");
        //        return word; 
        //    }
        //    char[] charArray = word.ToCharArray();
        //    charArray[position] = newChar;

        //    return new string(charArray);
        //}
        #endregion
        static void Main(string[] args)
        {
            #region CallQ1 
            //// passing by value (byvalue)
            //Console.WriteLine("Passing by value example:");
            //int a = 2, b =3 ;
            //Console.WriteLine($"values before call fun : {a},{b}" );
            //SumByValue(a,b);
            //Console.WriteLine($"values After call fun : {a},{b}");
            //// passing by value (byref)
            //Console.WriteLine("Passing by Ref example:");
            //Console.WriteLine($"values before call Reffun : {a},{b}");
            //SumByRef(ref a, ref b);
            //Console.WriteLine($"values After call Reffun : {a},{b}");



            #endregion

            #region CallQ2
            //int[] arr1 = [4, 5, 6];
            //Console.WriteLine(" arr1 Before Call Fun ");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}
            //SumArrayByValue(arr1);
            //Console.WriteLine(" arr1 After Call Fun ");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine($"Sum of arr1 is : {SumArrayByValue(arr1)}");
            //////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine(" arr1 Before Call Fun ");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}
            //SumArrayByRef(ref arr1);
            //Console.WriteLine(" arr1 After Call Fun ");
            //foreach (int num in arr1)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine($"Sum of arr1 is : {SumArrayByValue(arr1)}");

            #endregion

            #region CallQ3
            //int sum, sub;
            //Sum_SubFun(5,2, out sum, out sub);
            //Console.WriteLine($"Sum is : {sum} \nSub is : {sub}");
            #endregion

            #region CallQ4
            //Console.WriteLine("Enter a number:");
            //int num =int.Parse(Console.ReadLine() ?? "0");
            //SumOfDigits(num);
            #endregion

            #region CallQ5
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine() ?? "0");
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region CallQ6
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //MinMaxArray(Arr);
            //Console.WriteLine($"Max is : {Arr.Max()} \nMin is : {Arr.Min()}");
            #endregion

            #region CallQ7
            //Factorial(5);
            #endregion

            #region CallQ8
            //Console.WriteLine( ChangeChar("Salma", 1, 'K'));
            #endregion

        }
    }
}
