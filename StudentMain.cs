using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo1
{
    public class StudentMain
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Roll Number: ");
            int rollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks for Subject 1: ");
            int marks1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks for Subject 2: ");
            int marks2 = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks for Subject 3: ");
            int marks3 = int.Parse(Console.ReadLine());


            Student student = new Student(rollNo, name, marks1, marks2, marks3);


            Console.WriteLine("\nStudent Details:");
            student.DisplayDetails();


        }

    }
}
