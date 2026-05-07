using System;
using CodeFirstStudentApp.Models;

namespace CodeFirstStudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student
                {
                    Name = "John Doe",
                    Age = 22
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
                Console.ReadLine();
            }
        }
    }
}
