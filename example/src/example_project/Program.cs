﻿using System;

namespace example_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, x, y, z;
            z = 0;
            x = 1;
            n = 3;
            i = 1;
            while (i <= n)
            {
                x = x * -1;
                if (x < 0)
                {
                    y = x * x;
                }
                else
                {
                    y = x + x;
                }
                z = y + y + y;
                i = i + 1;
            }
            int j = z;
        }
    }
}
