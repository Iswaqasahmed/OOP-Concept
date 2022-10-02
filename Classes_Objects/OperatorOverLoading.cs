using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept.Classes_Objects
{
    public class OperatorOverLoading
    {

        public float image, real;
        internal OperatorOverLoading() { }


        // By using constructor to set value
        public OperatorOverLoading(int r, int i)
        {
            this.image = i;
            this.real = r;
        }

        public void getValue(float r, float i)
        {
            // user input set value
            Console.WriteLine("Enter Real & Imaginary Value");
            float real = Convert.ToSingle(Console.ReadLine());
            float image = Convert.ToSingle(Console.ReadLine());
            this.real = real;
            this.image = image;
        }

        public void setValue(float r, float i)
        {
            this.real = r;
            this.image = i;
        }
        public void displayData()
        {
            Console.WriteLine("Real Part = {0} & Imaginary Part = {1}", real, image);
        }

        // Overloading + operator
        public static OperatorOverLoading operator +(OperatorOverLoading x, OperatorOverLoading y)
        {
            OperatorOverLoading temp = new OperatorOverLoading();
            temp.real = x.real + y.real;
            temp.image = x.image + y.image;
            return temp;
        }

        public static OperatorOverLoading operator *(OperatorOverLoading x, OperatorOverLoading y)
        {
            OperatorOverLoading temp = new OperatorOverLoading();
            temp.real = x.real * y.real;
            temp.image = x.image * y.image;
            return temp;
        }
        public static OperatorOverLoading operator >=(OperatorOverLoading x, OperatorOverLoading y)
        {
            OperatorOverLoading temp = new OperatorOverLoading();
            temp.real = x.real * y.real;
            temp.image = x.image * y.image;
            return temp;
        }

        public static void Main()
        {
            OperatorOverLoading c1, c2, c3;
            
            c1 = new OperatorOverLoading();
            c1.setValue(2, 1);
            c2 = new OperatorOverLoading(1, 2);
            c3 = new OperatorOverLoading();
            c3 = c1 + c2;
            Console.WriteLine("Complex C3");
            c3.displayData();

            // Logic 2
            OperatorOverLoading c4, c5, c6;
            c4 = new OperatorOverLoading();
            c4.getValue(2, 1);
            c5 = new OperatorOverLoading(1, 2);
            c6 = new OperatorOverLoading();
            c6 = c4 * c5;
            Console.WriteLine("Complex C6");
            c6.displayData();


            // Logic 3
            OperatorOverLoading c7;
            c7 = new OperatorOverLoading();
            c7 = c1 + c2 * c3;
            Console.WriteLine("Complex C7");
            c7.displayData();

        }
    }
}
