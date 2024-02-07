﻿using System;
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

    }
}