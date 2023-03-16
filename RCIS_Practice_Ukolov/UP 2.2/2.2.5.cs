using System;
using System.CodeDom;

namespace practicercis
{
    public class practiceTask
    {
        public int a;
        public int b;
    
        public practiceTask()
        {
            this.a = 0;
            this.b = 10;
        }
        
        public practiceTask(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        ~practiceTask()
        {
            Console.WriteLine($"a({a}) и b({b}) упали с трубы");
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            void Test()
            {
                practiceTask test1 = new practiceTask();
                practiceTask test2 = new practiceTask(10, 20);
            }
            
            Test();
            GC.Collect();
        }
    }
}