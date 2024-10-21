using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo1
{
    internal class CalculateFactorial
    {
        //static void Main(string[] args)
        //{
        //    //.  Calculate factorial of a number. 
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        long result = FactorialRecursive(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }

    static long FactorialRecursive(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * FactorialRecursive(n - 1);

        //}

    }
}
