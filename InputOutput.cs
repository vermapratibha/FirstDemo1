using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo1
{
    internal class InputOutput
    {
        //static void Main(string[] args)
        //{
        //            int a = 10;
        //            int b = 20;
        //            //arthmetic 
        //            Console.WriteLine(a + b);
        //            Console.WriteLine(a - b);
        //            Console.WriteLine(a * b);
        //            Console.WriteLine(a / b);
        //            Console.WriteLine(a % b);

        //            Console.WriteLine(a == b);
        //            Console.WriteLine(a != b);


        //            Console.WriteLine(a > b);
        //            Console.WriteLine(a >= b);
        //            Console.WriteLine(a < b);
        //            Console.WriteLine(a <= b);


        //            //&&,||
        //            Console.WriteLine(a == b && b == a);
        //            Console.WriteLine(a< b || b >a);
        //            Console.WriteLine(!(a<b) );


        //           int t= (a > b) ? a : b;
        //            Console.WriteLine(t);

        //            //add two numbers
        //            //int x = 20, y = 80,sum=0;
        //            //sum = x + y;
        //            //Console.WriteLine("sum of two numbers:"+sum);

        //            Console.WriteLine("Enter Any Two Numbers : ");
        //           int n1 =Convert.ToInt32( Console.ReadLine());
        //            int n2 = Convert.ToInt32(Console.ReadLine());
        //            int sum = n1 + n2;
        //            Console.WriteLine(sum);


        //palindrome number
        //int rem, temp, sum = 0;
        //int n = 111;
        //temp = n;
        //while (n > 0)
        //{
        //    rem = n % 10;
        //    sum = (sum * 10) + rem;
        //    n = n / 10;
        //}
        //if (temp == sum)
        //{
        //    Console.WriteLine("palindrome num");
        //}
        //else
        //{
        //    Console.WriteLine(" not palindrome num");
        //}

        //dry run 
        //initial val n>0 n/10  digit rev
        //sum=0;
        // n=111 111>0 111%10=1 rev(0*10)+1=1
        //        11>0 11%10=1 rev(1*10)+1=11
        //         1>0 1%10=1 rev(11*10)+1=111

        //Write a C# program to check whether a year is leap year or not  

        // int year =2012;
        // bool leap = false;

        // if (year % 4 == 0) { 

        //     if(year % 100 == 0) { 

        //         if (year%400==0) 
        //             leap = true;
        //             else
        //                 leap = false;
        //     }
        //     else
        //         leap = true;
        // }

        //else
        // leap= false;

        //     if (leap)
        //         Console.WriteLine(year + " is leap year");
        //     else
        //         Console.WriteLine(year + " is not leap year");



        //Write a C# program to check whether a number is divisible by 5 and 11 or not 


        //int n;
        //n = 55;
        //if ((n % 5 == 0) && (n % 11 == 0))
        //{
        //    Console.WriteLine("number is divisible by 5 and 11");
        //}
        //else
        //{
        //    Console.WriteLine("number is not  divisible by 5 and 11");
        //}


        //3. Write a C# program to find maximum between three numbers  

        //int n1 = 10, n2 = 20, n3 = 30;
        // if (n1 > n2)
        //{
        //    if (n1 > n3)
        //    {
        //        Console.WriteLine("number n1 is maximum");
        //    }
        //    else
        //    {
        //        Console.WriteLine("number n3 is maximum");
        //    }
        //}
        //else if (n2 > n3)
        //{
        //    Console.WriteLine("number n2 is maximum");
        //}
        //else
        //{
        //    Console.WriteLine("number n3 is maximum");
        //}
        //4. Write a C# program to input any alphabet and check whether it is vowel or consonant
        //char ch = 'p';
        //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
        //{
        //    Console.WriteLine(ch+" is vowel");
        //}
        //else
        //{
        //    Console.WriteLine(ch + " is consonant");
        //}

        //  5.Write a C# program to create Simple Calculator   
        char operator;

         Double number1, number2, result;

        // create an object of Scanner class
        Console.WriteLine("Choose an operator: +, -, *, or /");
        Scanner input = new Scanner(System.in);

        // ask users to enter operator
        System.out.println("");
    operator = input.next().charAt(0);

        // ask users to enter numbers
        Console.WriteLine("Enter first number");
        System.out.println("");
        number1 = input.nextDouble();

             Console.WriteLine("Enter second number");
    int number2=Console.
        number2 = input.nextDouble();

    switch (operator) {

      // performs addition between numbers
      case '+':
        result = number1 + number2;
        Console. WriteLine(number1 + " + " + number2 + " = " + result);
        break;

      // performs subtraction between numbers
      case '-':
        result = number1 - number2;
      Console.WriteLine(number1 + " - " + number2 + " = " + result);
        break;

      // performs multiplication between numbers
      case '*':
        result = number1* number2;
        Console.WriteLine(number1 + " * " + number2 + " = " + result);
        break;

      // performs division between numbers
      case '/':
        result = number1 / number2;
       Console.WriteLine((number1 + " / " + number2 + " = " + result);
        break;

      default:
       Console.WriteLine(("Invalid operator!");
        break;
    }

    input.close();
  }
}

            

            //9. Write a C# program print total number of days in a month  
            //int month, year;
            //month = 12;
            //year = 2012;
            //if ((month ==2) && ((year % 4 == 0) || ((year % 100!= 0) && (year % 400 == 0))))

            //    Console.WriteLine("number of days in 29");

            //else if (month == 2)
            //     Console.WriteLine("number of days in 28");
            //else if(month == 1||month==3||month==5||month==7||month==8||month==10||month==12)
            //                     Console.WriteLine("number of days in 31");
            //else
            //{
            //    Console.WriteLine("number of days in 30");
            //}


            //            Write a C# program to input basic salary of an employee and calculate its  
            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %, 
            //DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %
            //
            //  1.Display numbers from 1 to 100.
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //2.  Display all even numbers from 1 to 100. 
            //int n = 100;

            //if(n%2==0)
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //3.  Display all odd numbers from 200 to 300. 
            //11.  Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ..... k. where k < n . n is entered by user 

            //int n1 = 0, n2 = 1, n3,count=10;
            //Console.WriteLine(n1+""+n2);
            //for(int i = 2; i <= count; i++)
            //{
            //    n3 = n1 + n2;
            //    Console.WriteLine(""+n3);
            //    n1 = n2;
            //    n2 = n3;
            //}
            //4.  Find out if the given number is palindrome or not.

            //int rem, temp, sum = 0;
            //int number = 212;
            //temp = number;
            //while (number > 0)
            //{
            //    rem = number % 10;
            //    sum =(sum*10) + rem;
            //    number= number/10;

            //}
            //if (temp == sum)
            //{
            //    Console.WriteLine("palindrome number");
            //}
            //else
            //{
            //    Console.WriteLine("not palindrome number");
            //}
            //{

            //}
            //15.        Write a Java program to find the frequency of each digit in a given integer.
            //int n = 112314,c=0;
            //int freq = 1;
            //while (n > 0)
            //{
            //int r=n % 10;
            //    if (r == freq)

            //        c++;
            //        n /= 10;


            //}
            //Console.WriteLine("frequency of each digit : " + c);

            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20%, DA = 80% Basic Salary <= 20000 : HRA = 25%, 
            // DA = 90 % Basic Salary > 20000 : HRA = 30 %, DA = 95 %


            //    


            //Display the seventh element between 400 to 500 (both numbers excluded). 


    }
}
