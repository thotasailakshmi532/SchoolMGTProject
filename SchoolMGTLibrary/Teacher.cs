using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGTLibrary
{
    public class Teacher
    {
        public int Age { get; set; }
        public Teacher()
        {
            Console.WriteLine("Default constructor of teacher");
        }
        public Teacher(int age)
        {
            Console.WriteLine($"The parameterized constructor with age: {age}");
        }
    }
    public class SeniorTeacher:Teacher
    {
        public string  Tname { get; set; }
        public string  Sname { get; set; }
        public SeniorTeacher()
        {
            Console.WriteLine("Default Constructor of senior teacher");
        }
        public SeniorTeacher(string name,string subject,int age):base(age) 
        {
            Tname= name;
            Sname= subject;
            Console.WriteLine("Parameterised of name and subject name of senior teacher");
        }
    }
}
