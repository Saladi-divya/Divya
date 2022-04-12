using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 76, 49, 63,40, 90, 100, 49, 68 ,24 , 36 , 52 , 58, 87, 87 };
            int[] array2 = new int[] { 5, 97, 43, 50, 45, 39, 67, 100, 90, 10, 55, 70, 57, 70 };

            Console.WriteLine("*******UNION*******");
            var query1 = (from i in array1 select i).Union(from j in array2 select j);

            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******INTERSECT*******");

            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);

            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******EXCEPT*******");

            var query3 = (from i in array1 select i).Except(from j in array2 select j);

            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*******CONCAT*******");

            var query4 = (from i in array1 select i).Concat(from j in array2 select j);

            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("********Aggregate Functions for array1 and array2*******");


            Console.WriteLine("----Sum----");

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();

            Console.WriteLine(" Sum of numerbs in array1-" + sum1);
            Console.WriteLine(" Sum of numerbs in array1-" + sum2);

            Console.WriteLine("---Maximum---");

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();

            Console.WriteLine("Maximum number array1:-" + max1);
            Console.WriteLine("Maximum number array2:-" + max2);


            Console.WriteLine("----Minimum----");

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();

            Console.WriteLine("Minimum number in array1:-" + min1);
            Console.WriteLine("Minimum number in array2:-" + min2);


            Console.WriteLine("----Average----");

            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();

            Console.WriteLine("Average of array1" + avg1);
            Console.WriteLine("Average of array2" + avg2);


            Console.WriteLine("----Count-----");

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();

            Console.WriteLine("Total number of elements in  array1:-" + count1);
            Console.WriteLine("Total number of elements in  array2:-" + count2);

            Console.WriteLine("----Distinct-----");
            Console.WriteLine("distinct elements in array1");
            var distinct1 = (from i in array1 select i).Distinct();
            foreach (int i in distinct1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("distinct elements in array2");
            var distinct2 = (from i in array2 select i).Distinct();
            foreach (int i in distinct2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
