using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc
{
    public class Functions
    {
        //public static int FindLargest(List<int> ints)
        //{
        //    int largest = int.MinValue;
        //    foreach (int i in ints) {
        //        if (i > largest) { largest = i; }
        //    }
        //    return largest;
        //}
        //public static double FindLargest(List<double> doubles)
        //{
        //    double largest = double.MinValue;
        //    foreach (double i in doubles)
        //    {
        //        if (i > largest)
        //        {
        //            largest = i;
        //        }
        //    }
        //    return largest;
        //}
        //public static string FindLargest(List<string> strings)
        //{
        //    string largest = string.Empty;
        //    foreach (string s in strings)
        //    {
        //        if (s.Length >= largest.Length)
        //        {
        //            largest = s;
        //        }
        //    }
        //    return largest;
        //}

        public static T FindLargest<T>(List<T> list) where T : IComparable<T>
        {
            if (list == null || list.Count == 0) throw new ArgumentNullException("Listen er ikke valid");
            else {
                T largest = list[0];
            for (int i = 1; i < list.Count; i++) {
                    int compare = list[i].CompareTo(largest);
                    if (compare == 1) { largest = list[i]; }
                    else if (compare == 0) { largest = list[i]; }
                }
                return largest;
            }
        }
    }
}
