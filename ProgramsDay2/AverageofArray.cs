﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefresherPrograms
{
    internal class AverageofArray
    {
        public float average(float[] arr)
        {
            float sum = 0, avg = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum+= arr[i];
            }
            avg = sum/ arr.Length;
            return avg;
        }
    }
}
