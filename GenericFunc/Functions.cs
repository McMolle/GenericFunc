using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc
{
    public class Functions
    {
        public static int FindLargest(List<int> ints)
        {
            int largest = int.MinValue;
            foreach (int i in ints) {
                if (i > largest) { largest = i; }
            }
            return largest;
        }
        public static double FindLargest(List<double> doubles)
        {
            double largest = double.MinValue;
            foreach (double i in doubles)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            return largest;
        }
        public static string FindLargest(List<string> strings)
        {
            string largest = string.Empty;
            foreach (string s in strings)
            {
                if (s.Length >= largest.Length)
                {
                    largest = s;
                }
            }
            return largest;
        }
    }
}
