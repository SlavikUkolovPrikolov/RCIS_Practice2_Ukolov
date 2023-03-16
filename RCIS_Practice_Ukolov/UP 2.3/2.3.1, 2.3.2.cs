using System;

namespace UkolovVR
{
    public class Worker
    {
        public string name;
        public string Name
        {
            get 
            {
                return name;
            }
        }
    
        public string surname;
        public string Surname
        {
            get 
            {
                return surname;
            }
        }
    
        public int rate;
        public int Rate 
        {
            get 
            {
                return rate;
            }
        }
    
        public int days;
        public int Days 
        {
            get 
            {
                return days;
            }
        }
    
        public Worker(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }
    
        public void Changes(string name, string surname, int rate, int days)
        {
            this.name = name;
            this.surname = surname;
            this.rate = rate;
            this.days = days;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Daily rate: {rate} USD., Days worked: {days}");
        }
    
        public void GetSalary()
        {
            int salary = rate * days;
            Console.WriteLine($"Employee salary = {salary} USD.");
        }
    }

    internal class Program
    { 
        public static void Main()
        {
            Worker worker1 = new Worker("Vyacheslav", "Prikolov", 1500, 20);
            worker1.Print();
            worker1.GetSalary();
            worker1.Changes("Vyacheslav", "Ukolov", 2500, 10);
            worker1.Print();
            worker1.GetSalary();
        }
    }
}  