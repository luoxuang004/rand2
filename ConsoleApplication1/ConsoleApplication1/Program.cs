﻿using System;
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
            List<string> member = new List<string>();

            member.Add("Peter");
            member.Add("Jamie");
            member.Add("Maggie");
            member.Remove("Jamie");
            member.RemoveAt("1");

        }
    }
}