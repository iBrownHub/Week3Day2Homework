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
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByName(d));
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByLength(d));
            c.name = "Carly";
            d.name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByName(d));
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByLength(d));
            c.name = "Edward";
            d.name = "Carly";
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByName(d));
            Console.WriteLine("{0} compared to {1} is {2}", c.name, d.name, c.CompareByLength(d));
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
