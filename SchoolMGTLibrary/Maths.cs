using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMGTLibrary
{
    public delegate int Operations(int i, int j);
    public class Maths
    {
        public int Add(int i,int j)
        {
            return i + j;
        }
        public int Subtract(int i,int j) 
        { 
            return i - j; 
        }
        public int Multiply(int i,int j) 
        {
            return i * j;
        
        }
    }
}
