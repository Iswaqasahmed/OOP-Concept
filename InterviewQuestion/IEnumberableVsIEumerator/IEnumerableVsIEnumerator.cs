using System;
using System.Collections.Generic;

namespace OOP_Concept.InterviewQuestion.IEnumberableVsIEumerator
{
    public class IEnumerableVsIEnumerator
    {

        //IEnumerable and IEnumerator

        public void IEnumberableVsIEumeratorDifference()
        {


            // IEnumerable vs IEnumerator
            //1. IEnumerable is internally use IEnumerator. ( sugar coating )
            //2. IEnumerable is not record the current state of which is executing.




            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");
            list.Add("I");
            list.Add("G");
            list.Add("K");
            list.Add("L");
            list.Add("M");
            list.Add("M");


            //IEnumerable<string> ienum = list;

            //foreach (string item in ienum)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<string> ienumerator = list.GetEnumerator();
            IteratorExample(ienumerator);

            IEnumerable<string> ienum = list;
            IteratorExample3(ienum);
            //while (ienumerator.MoveNext())
            //{
            //    Console.WriteLine(ienumerator.Current);
            //}


        }

        public void IteratorExample(IEnumerator<string> ienumerator)
        {
            try
            {
                Console.WriteLine("IteratorExample -  Method is Called ");

                while (ienumerator.MoveNext())
                {
                    Console.WriteLine(ienumerator.Current);
                    if (ienumerator.Current == "H")
                        IteratorExample2(ienumerator);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void IteratorExample2(IEnumerator<string> ienumerator)
        {
            try
            {
                Console.WriteLine("IteratorExample - 2 Method is Called ");
                while (ienumerator.MoveNext())
                {
                    
                    
                    Console.WriteLine(ienumerator.Current);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        public void IteratorExample3(IEnumerable<string> ienumerator)
        {
            try
            {
                Console.WriteLine("IteratorExample - 3 Method is Called : IEnumerable ");
                foreach (var item in ienumerator)
                {
                    Console.WriteLine(item);
                    if (item == "H")
                        IteratorExample4(ienumerator);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void IteratorExample4(IEnumerable<string> ienumerator)
        {
            try
            {
                Console.WriteLine("IteratorExample - 4 Method is Called : IEnumerable ");
                foreach (var item in ienumerator)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


    }
}
