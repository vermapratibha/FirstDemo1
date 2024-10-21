using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstDemo1
{
    public class Student
    {
        public int rollNo;
        public string name;
        public int marks1;
        public int marks2;
        public int marks3;

        public Student(int rollNo, string name, int marks1, int marks2, int marks3)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks1 = marks1;
            this.marks2 = marks2;
            this.marks3 = marks3;
        }

    
        public int CalculateTotalMarks()
        {
            return marks1 + marks2 + marks3;
        }


        public double CalculatePercentage()
        {
            int totalMarks = CalculateTotalMarks();
            return (totalMarks / 3.0);
        }
      
        public void DisplayDetails()
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Marks 1: {marks1}, Marks 2: {marks2}, Marks 3: {marks3}");
            Console.WriteLine($"Total Marks: {CalculateTotalMarks()}");
            Console.WriteLine($"Percentage: {CalculatePercentage():F2}%");
        }
    

    
    }
}
