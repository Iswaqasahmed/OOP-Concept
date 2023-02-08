using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Concept
{
    public class InumtorVsInumRable
    {

        public List<string> getDummyData()
        {
            try
            {
                List<string> dummyData = new List<string>();
                dummyData.Add("A");
                dummyData.Add("B");
                dummyData.Add("C");
                dummyData.Add("D");
                dummyData.Add("E");
                dummyData.Add("F");
                dummyData.Add("G");
                dummyData.Add("H");
                dummyData.Add("I");
                dummyData.Add("J");
                dummyData.Add("K");
                dummyData.Add("L");
                dummyData.Add("M");
                dummyData.Add("N");
                dummyData.Add("O");
                dummyData.Add("P");
                dummyData.Add("Q");
                dummyData.Add("R");
                dummyData.Add("S");
                dummyData.Add("T");
                dummyData.Add("U");
                dummyData.Add("V");
                dummyData.Add("W");
                dummyData.Add("X");
                dummyData.Add("Y");
                dummyData.Add("Z");
                return dummyData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Interator()
        {
            try
            {

                // Key Point difference
                // 1. Internally IEnumerable<T> is implemented by IEnumerator<T>
                // 2. IEnumerable<T> is not remebering the state of the iteration
                // 3. IEnumerable<T> is not thread safe
                // 4. IEnumerable<T> is not having any method to reset the iteration
                // 5. IEnumerable<T> is not having any method to move to the previous item
                // 6. IEnumerable<T> is not having any method to move to the specific item
                // 7. IEnumerable<T> is not having any method to get the current item
                // 8. IEnumerable<T> is not having any method to get the current index
                // 9. IEnumerable<T> is not having any method to get the total number of items


                
                IEnumerable<string> items =  getDummyData();
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }


                IEnumerator<string> enumerator = items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }

                

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void iterateOverAtoS(List<string> lis)
        {
            try
            {
                foreach (var item in lis)
                {
                    if (item == "S")
                    {
                        break;
                    }
                    Console.WriteLine(item);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}