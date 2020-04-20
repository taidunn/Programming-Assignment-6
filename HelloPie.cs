using System;

namespace Programming_Assignment_6
{
   class Program
   {


      public static double F(int i)
      {
         //return 1 + i / (2.0 * i + 1) * F(i + 1);
         if (i == 0)
         {
            return 0;
         }
         else
         {
            //(-1)n - 1 / (2n - 1)
            return ((Math.Pow(-1.0, i - 1)) / (2.0 * i - 1)) + F(i - 1);

         }
      }

      static void Main(string[] args)
      {
         int n = 0;

         Console.Write(": ");
         n = int.Parse(Console.ReadLine());


         Console.WriteLine($"PI is... {F(n)*4} \n");
         //Console.WriteLine($"PI is... f({n})= {F(n)} \n");
      }
   }
}
