using System;

namespace UkolovVR
{
    public class Nums
    {
        public int number1;
        public int number2;
    
        public Nums(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
    
        public void Print()
        {
            Console.WriteLine($"1st number = {number1}, 2nd number = {number2}");
        }
    
        public void Changes(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
    
        public void Sum()
        {
            Console.WriteLine(number1 + number2);
        }
    
        public void Max()
        {
            if (number1 > number2)
            {
                Console.WriteLine($"{number1} > {number2}");
            }
            else
            {
                Console.WriteLine($"{number2} > {number1}");
            }
        }
    }

    internal class Program
    { 
        public static void Main()
        {
            Nums nums1 = new Nums(3, 1);
            nums1.Print();
            nums1.Changes(6, 4);
            nums1.Print();
            nums1.Sum();
            nums1.Max();
        }
    }
}  