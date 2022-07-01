using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of the count");
            int Count = Convert.ToInt32(Console.ReadLine());
            Counter instance = Counter.Getinstance;


            Console.WriteLine(instance.increment(Count));
            Console.WriteLine(instance.decrement(Count));
            Console.ReadLine();
        }
    }


    public class Counter
    {
        private static Counter getinstance = null;

        private Counter()
        {
        }

        public static Counter Getinstance
        {

            get
            {
                if (getinstance == null)
                {
                    getinstance = new Counter();
                }
                return getinstance;
            }
        }
        public int increment(int count)
        {
            count++;
            return count;
        }

        public int decrement(int count)
        {
            count--;
            return (count);
        }

    }



}
