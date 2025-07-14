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



        }
    }
}
