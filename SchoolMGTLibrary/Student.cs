using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGTLibrary
{
    //step1:Declared the delegates fr showDetails() and the signature must match
    public delegate void Print();
    
    public class Student
    {
       

        public int StudRollNo { get; set; }
        public string StudName { get; set; }
        public int StudAge { get; set; }
        public String city { get; set; }
        //Access specifier are not allowed to static constructor
        static Student()
        {
            //First constructor to be called in the sequence and it is called only once in the lifetime class
            Console.WriteLine(  "Static Constructor");
            Console.WriteLine("Used for initalising the data of the app for the entity");
        }
        public Student()
        {
            Console.WriteLine("Default constructor");


        }
        public Student( int rollno,string name,string city)
        {
            StudRollNo=rollno;
            StudName=name;
            this.city=city;//this is used when variable and constructor parameter are same
            Console.WriteLine("Roono,name,city parameterized constructor");


        }
        public Student(int rollno,string name,int age)
        {
            StudRollNo =rollno;
            StudName=name;
            StudAge=age;
            Console.WriteLine("Rollno,name,Age  parameterized constructor");
        }
        public Student(int rollno,string name,String city,int age):this(rollno,name,age) 
        {
            this.city = city;

            
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Rollno :{StudRollNo}\n Student Name:{StudName}\n StudAge{StudAge} \n City: {city}");
        }


    }
}
