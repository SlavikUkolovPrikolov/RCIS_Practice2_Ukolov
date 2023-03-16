using System;

namespace UkolovVR
{
    public class Student
    {
        public string surname;
        public DateTime birthDate;
        public int group;
        public int[] progress;
    
        public Student(string surname, DateTime birthDate, int group, int[] progress)
        {
            this.surname = surname;
            this.birthDate = birthDate;
            this.group = group;
            this.progress = progress;
        }
    
        public void Print()
        {
            Console.WriteLine($"Surname: {surname}, Birth date: {birthDate}, Group: {group}");
            Console.WriteLine("Progress");
            for (int i = 0; i < progress.Length; ++i)
            {
                Console.WriteLine(progress[i]);
            }
        }
    
        public void Changes(string surname, DateTime birthDate, int group, int[] progress)
        {
            this.surname = surname;
            this.birthDate = birthDate;
            this.group = group;
            this.progress = progress;
        }
    }
    
    internal class Program
    {
        public static void Main()
        {
            Student slava = new Student(surname: "Ukolov", birthDate: new DateTime(2004, 11, 8), group: 621, progress: new int[5] {5, 4, 5, 4, 5});
            slava.Print();
            slava.Changes(surname: "Prikolov", birthDate: new DateTime(2004, 8, 11), group: 126, progress: new int[5] {5, 5, 5, 5, 5});
            slava.Print();
        }
    }
}