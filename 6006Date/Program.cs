using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6006Date
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            // Test1();            // Testing Date(d,m,y), Setters and Getters
            // Test2();            // Testing esting IsLater() and IsEqual()  
            // Test3();            // Testing Date(d), Tomorrow() and DaysDifference()
            Test4();
            Console.ReadLine();

            
        }

        public static void Test1()
        {
            Random rnd = new Random();
            int t = 0;
            Date[] dArr = new Date[12];
            int d , m , y;
            for (int i = 0; i< dArr.Length; i++)
            {
                dArr[i] = new Date(i + 10, i + 1, i + 2010);
            }
            Console.WriteLine("Test1:Testing ToString()");
            for (int i = 0; i < dArr.Length; i++)
            {
                d = i + 10;
                m = i + 1;
                y = i + 2010;
                string str = (d + "-" + m + "-" + y);
                if (String.Equals(dArr[i].ToString(), str))
                {
                    Console.WriteLine("Test1-{0}: Good", t);
                }
                else
                {
                    Console.WriteLine("Test1-{0}: Error, expected {1}, actual: {2}", t , str , dArr[i].ToString());
                }
                t++;
            }

            Console.WriteLine("Test1: Testing Setters and Getters");
            Console.WriteLine("Test1: Testing SetDay() and GetDay()");
            for (int i = 0; i < dArr.Length; i++)
            {
                d = rnd.Next(1, 31);
                dArr[i].SetDay(d);
                if (dArr[i].GetDay() == d)
                {
                    Console.WriteLine("Test1-{0}: Good", t);
                }
                else
                {
                    Console.WriteLine("Test1-{0}: Error, expected {1}, actual: {2}", t, d, dArr[i].GetDay());
                }
                t++;
            }
            Console.WriteLine("Test1: Testing SetMonth() and GetMonth()");
            for (int i = 0; i < dArr.Length; i++)
            {
                m = rnd.Next(1, 13);
                dArr[i].SetMonth(m);
                if (dArr[i].GetMonth() == m)
                {
                    Console.WriteLine("Test1-{0}: Good", t);
                }
                else
                {
                    Console.WriteLine("Test1-{0}: Error, expected {1}, actual: {2}", t, m, dArr[i].GetMonth());
                }
                t++;
            }

            Console.WriteLine("Test1: Testing SetYear() and GetYear()");
            for (int i = 0; i < dArr.Length; i++)
            {
                y = rnd.Next(2000, 2021);
                dArr[i].SetYear(y);
                if (dArr[i].GetYear() == y)
                {
                    Console.WriteLine("Test1-{0}: Good", t);
                }
                else
                {
                    Console.WriteLine("Test1-{0}: Error, expected {1}, actual: {2}", t, y, dArr[i].GetYear());
                }
                t++;
            }
        }

        public static void Test2()
        {
            int t = 0;
            Console.WriteLine("Test2: Testing IsLater() and IsEqual()");
            Date d1 = new Date(1, 1, 1);
            Date d2 = new Date(1, 1, 2);
            Date d3 = new Date(2, 2, 2);
            Date d4 = new Date(1, 1, 2);
            Date d5 = new Date(2, 3, 2);
            Date d6 = new Date(4, 5, 6);
            Date d7 = new Date(4, 5, 6);

            if (d6.IsEqual(d7))
            {
                Console.WriteLine("Test2-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected equal dates, actual: not-equal" , t);
            }
            t++;

            if (d2.IsEqual(d4))
            {
                Console.WriteLine("Test2-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected equal dates, actual: not-equal", t);
            }
            t++;
            if (!d6.IsLater(d7))
            {
                Console.WriteLine("Test2-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected not Later date, actual: Later", t);
            }
            t++;
            if (!d3.IsLater(d5))
            {
                Console.WriteLine("Test2-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected not Later date, actual: Later", t);
            }
            t++;
            if (d2.IsLater(d1))
            {
                Console.WriteLine("Test2-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected Later date, actual:  not Later", t);
            }
            t++;
        }

        public static void Test3()
        {
            int t = 0;
            Random rnd = new Random();
            Console.WriteLine("Test3: Testing Date(d), Tomorrow() and DaysDifference()");
            Date d1 = new Date(rnd.Next(1 , 31) , rnd.Next(1 , 13) , rnd.Next(1990 , 2011));
            Date d2 = new Date(d1);
            d2.Tomorrow();
            if (d2.DaysDifference(d1) == 1)
            {
                Console.WriteLine("Test3-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected differnce 1, actual:  {1}", t , d2.DaysDifference(d1));
            }
            t++;
            if (d1.DaysDifference(d2) == -1)
            {
                Console.WriteLine("Test3-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected differnce 1, actual:  {1}", t, d1.DaysDifference(d2));
            }
            t++;
            int days = rnd.Next(2, 100);
            for(int i = 0; i < days; i++)
            {
                d2.Tomorrow();
            }
            if (d2.DaysDifference(d1) ==  days + 1)
            {
                Console.WriteLine("Test3-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected differnce {1}, actual:  {2}", t, days + 1 , d2.DaysDifference(d1));
            }
            t++;
            if (d1.DaysDifference(d2) == -1 * (days + 1))
            {
                Console.WriteLine("Test3-{0}: Good", t);
            }
            else
            {
                Console.WriteLine("Test2-{0}: Error, expected differnce {1}, actual:  {2}", t, -1 * (days + 1) , d1.DaysDifference(d2));
            }
        }

        public static void Test4()
        {
            Date d1 = new Date(5, 4, 2020);
            Date d2 = new Date(d1);
            Console.WriteLine("d1: {0}", d1.ToString());
            Console.WriteLine("d2: {0}", d2.ToString());

            Console.WriteLine("d1.IsEqual(d2): {0}", d1.IsEqual(d2));
            Console.WriteLine("d2.IsEqual(d1): {0}", d2.IsEqual(d1));
            Console.WriteLine("d1.IsEqual(d1): {0}", d1.IsEqual(d1));

            d2.Tomorrow();
            d2.Tomorrow();
            Console.WriteLine("d2: {0}", d2.ToString());
            Console.WriteLine("d1: {0}", d1.ToString());

            Console.WriteLine("Days deifference from d1 to d2: {0}", d1.DaysDifference(d2));
            Console.WriteLine("Days deifference from d2 to d1: {0}", d2.DaysDifference(d1));
        }
    }
}
