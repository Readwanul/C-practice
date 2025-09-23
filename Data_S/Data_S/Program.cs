using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_S
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Alice", new DateTime(2003, 5, 15), 12345, "Computer Science");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Occupation:{student.getoccupation}");
            Console.WriteLine($"Age Status: {student.checkAdult()}");
            Console.WriteLine($"Student ID: {student.StudentID}");
            Console.WriteLine($"Major: {student.Major}");

        }
    }
}
