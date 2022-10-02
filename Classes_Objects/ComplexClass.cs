using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept.Classes_Objects
{
    public class ComplexClass
    {

        private float real, imag;

        public ComplexClass()
        {

        }


        public ComplexClass(float real, float imag)
        {
            this.real = real;
            this.imag = imag;
        }
        
        public void GetData()
        {
            float r, i;
            Console.WriteLine("Enter Read & Imaginary Part");
            r = Convert.ToSingle(Console.ReadLine());
            i = Convert.ToSingle(Console.Read());
            real = r;
            imag = i;

        }

        public void SetData(float r,float i)
        {
            this.real = r;
            this.imag = i;
        }

        public void DisplayData()
        {
            Console.WriteLine("Real Part = {0} & Imaginary Part = {1}", real, imag);
        }


        public ComplexClass Add(ComplexClass c1, ComplexClass c2)
        {
            ComplexClass c3 = new ComplexClass();
            c3.real = c1.real + c2.real;
            c3.imag = c1.imag + c2.imag;
            return c3;
        }
        
        public ComplexClass AddComplex (ComplexClass y)
        {
            ComplexClass temp = new ComplexClass();
            temp.real = this.real + y.real;
            temp.imag = this.imag + y.imag;
            return temp;
        }
        
        public ComplexClass MulComplex(ComplexClass y)
        {
            ComplexClass temp = new ComplexClass();
            temp.real = this.real * y.real - this.imag * y.imag;
            temp.imag = this.real * y.imag + this.imag * y.real;
            return temp;
        }

        
        

    }


    class ComplexNumber
    {
        static void Main(string[] args)
        {
            ComplexClass c1, c2, c3;
            c1 = new ComplexClass();
            c1.SetData(2, 3);
            c2 = new ComplexClass();
            c3 = new ComplexClass();
            c3 = c1.AddComplex(c2);
            Console.WriteLine("Complex C3");
            c3.DisplayData();
            

        }
    }

    
}
