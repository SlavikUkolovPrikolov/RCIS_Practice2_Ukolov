using System;

namespace UkolovVR
{
    public class Counter
    {
        public int number;
    
        public Counter(int number)
        {
            this.number = number;
        }
    
        public Counter()
        {
            number = 0;
        }
    
        public void Print()
        {
            Console.WriteLine($"Ваше число - {number}");
        }
    
        public void Increment()
        {
            number++;
        }
    
        public void Decrement()
        {
            number--;
        }
    }

    internal class Program
    { 
        public static void Main()
        {
            Counter num1 = new Counter();
            num1.Print();
            num1.Increment();
            num1.Increment();
            num1.Decrement();
            num1.Print();
        
            Counter num2 = new Counter(1000);
            num2.Print();
            num2.Decrement();
            num2.Print();
        }
    }
}  