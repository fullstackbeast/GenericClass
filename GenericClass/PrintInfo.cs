using System;
using System.Collections.Generic;

namespace GenericClass
{
    public class PrintInfo<T> 
    {
        
        public void Print(T value)
        {
            Console.WriteLine(value);
        }
    }
}