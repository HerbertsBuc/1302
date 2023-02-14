using System;

namespace LearningHithub
{
    internal class Program
    {
        private static object keyNumbers;      

        static void Main(string[] args)
        {            
            Console.WriteLine(Add(4, 5));   
            Console.ReadKey();
        }
        static int Add(int a, int b)
        {
            return a + b;                       
        }       
    }
}
