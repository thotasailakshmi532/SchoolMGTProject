using SchoolMGTLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGTProject
{
    internal class Program
    {
        //events are declared inside the class
        //public static event Print WhenDetailsReceived;
        public static event Operations DoCalculation;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first no");
            int fno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("EAnter second number");
            int sno=Convert.ToInt32(Console.ReadLine());
            Maths m = new Maths();
            Console.WriteLine("Enter your choices");
            int UserChoice=Convert.ToInt32(Console.ReadLine());
           
            switch(UserChoice)
                {
                case 1:
                    //Delegates is args event Handler

                    Operations opAdd = new Operations(m.Add);//m.Add is called (event handler)  method that is executed when the delegate receves a call using  opAdd is delegate object
                    DoCalculation += opAdd;//DoCalculation event
                    int addans = DoCalculation(fno, sno);//when event fires the delegates gives a call to the handler of the event which is method
                    Console.WriteLine(addans);
                    break;
                    case 2:
                    Operations opSub = new Operations(m.Subtract);
                    DoCalculation += opSub;
                    int subans = DoCalculation(fno, sno);
                    Console.WriteLine(subans);
                    break;
                    case 3:
                    Operations opMul = new Operations(m.Multiply);
                    DoCalculation += opMul;
                    int mulans = DoCalculation(fno, sno);
                    Console.WriteLine(mulans);
                    break;




            }


            //Student  s=new Student();
            //Student s1= new Student(1,"Nani","Hyderabad");
            //Student s2 = new Student(2, "Laksha", 8);
            //Console.ReadLine();
            //SeniorTeacher sr = new SeniorTeacher("Hari Kumar","Maths",30);
            //Student s= new Student(101,"Laxmi","Hyderabad",20);
            //step2-Create  a obj of the delegate,becz delegates is a referencetype,for reference type we create object.
            //Print p = new Print(s.ShowDetails);//wiring delegate with method
            //WhenDetailsReceived += p;//wiring event with delegate
            //step3:Call the delegate/Invoke the delegate
            //p();
            //WhenDetailsReceived();
            Console.ReadLine();
        }
    }
}
