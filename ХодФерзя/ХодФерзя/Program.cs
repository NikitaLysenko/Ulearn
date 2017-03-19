﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ХодФерзя
{
    class Program
    {
        public static void Main()
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            TestMove("a1", "a1");
        }

        public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        }

        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
            var dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали
            return ((dx == dy || dx == 0 || dy == 0) && from != to) ? true : false;
        }
    }
}
