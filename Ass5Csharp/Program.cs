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

           

        }
    }
}
