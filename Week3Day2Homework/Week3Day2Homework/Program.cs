using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Week3Day2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Item();
            var b = new Item();
            a.Name = "Bob";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Carly";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            a.Name = "Edward";
            b.Name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", a.Name, b.Name, a.CompareTo(b));
            var c = new Comparison();
            var d = new Comparison();
            c.name = "Bob";
            d.name = "Carly";
            if (c.CompareByName(d) == -1)
            {
                Console.WriteLine("Alphabetically, {0} comes before {1}", c.name, d.name);
            }
            else if (c.CompareByName(d) == 0)
            {
                Console.WriteLine("Alphabetically, {0} is the same as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("Alphabetically, {0} comes after {1}", c.name, d.name);
            }
            if (c.CompareByLength(d) == -1)
            {
                Console.WriteLine(" {0} is shorter than {1}", c.name, d.name);
            }
            else if (c.CompareByLength(d) == 0)
            {
                Console.WriteLine("{0} is the same length as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("{0} is longer than {1}", c.name, d.name);
            }
            c.name = "Carly";
            d.name = "Carly";
            if (c.CompareByName(d) == -1)
            {
                Console.WriteLine("Alphabetically, {0} comes before {1}", c.name, d.name);
            }
            else if (c.CompareByName(d) == 0)
            {
                Console.WriteLine("Alphabetically, {0} is the same as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("Alphabetically, {0} comes after {1}", c.name, d.name);
            }
            if (c.CompareByLength(d) == -1)
            {
                Console.WriteLine(" {0} is shorter than {1}", c.name, d.name);
            }
            else if (c.CompareByLength(d) == 0)
            {
                Console.WriteLine("{0} is the same length as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("{0} is longer than {1}", c.name, d.name);
            }
            c.name = "Edward";
            d.name = "Carly";
            if (c.CompareByName(d) == -1)
            {
                Console.WriteLine("Alphabetically, {0} comes before {1}", c.name, d.name);
            }
            else if (c.CompareByName(d) == 0)
            {
                Console.WriteLine("Alphabetically, {0} is the same as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("Alphabetically, {0} comes after {1}", c.name, d.name);
            }
            if (c.CompareByLength(d) == -1)
            {
                Console.WriteLine(" {0} is shorter than {1}", c.name, d.name);
            }
            else if (c.CompareByLength(d) == 0)
            {
                Console.WriteLine("{0} is the same length as {1}", c.name, d.name);
            }
            else
            {
                Console.WriteLine("{0} is longer than {1}", c.name, d.name);
            }
        }
    }
    public class Item : IComparable
    {
        public string Name;

        public int CompareTo(object o)
        {
            Item that = o as Item;
            return this.Name.CompareTo(that.Name);
        }
    }    
}
