﻿using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcs db = new mcs())
            {
                foreach (var stopReason in db.AccessTab)
                {
                    Console.WriteLine(stopReason.intTabID + "\t" + stopReason.strTabName);
                }
            }
        }
    }
}
