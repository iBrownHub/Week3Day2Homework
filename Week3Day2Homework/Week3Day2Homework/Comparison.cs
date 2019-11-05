using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Day2Homework
{
    public class Comparison : ICompareByName, ICompareByLength
    {
        public string name;                
        public int CompareByName(object o)
        {
            Comparison that = o as Comparison;
            return this.name.CompareTo(that.name);
        }
        public int CompareByLength(object o)
        {
            Comparison that = o as Comparison;
            return this.name.Length.CompareTo(that.name.Length);
        }        
    }
    interface ICompareByName
    {
        int CompareByName(object o);
    }
    interface ICompareByLength
    {
        int CompareByLength(object o);
    }
}
