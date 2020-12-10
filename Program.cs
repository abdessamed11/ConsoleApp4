using System;

namespace ConsoleApp4
{
    class Program
    {
        static void change(ref int i)
        {
            i = i + 15;
        }
        static void Main(string[] args)
        {

            int val = 10;
            change(ref val);
            Console.WriteLine(val);
            
            
         
        }
    }
}
