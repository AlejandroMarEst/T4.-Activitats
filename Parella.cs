﻿using System;

namespace T4._Activitats
{
    public class Parella <T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }
        public Parella(T1 value1, T2 value2) { 
            Value1 = value1;
            Value2 = value2;
        }
        public void ShowValues()
        {
            Console.WriteLine("{0},{1}", this.Value1, this.Value2);
        }
    }
}
