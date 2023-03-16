using System;

namespace UkolovVR
{
    public class Train
    {
        public string destination;
        public int number;
        public DateTime time;

        public Train(string destination, int number, DateTime time)
        {
            this.destination = destination;
            this.number = number;
            this.time = time;
        }

        public void Print()
        {
            Console.WriteLine($"Destination: {destination}, Train number: {number}, Dispatch time: {time}");
        }

        public void Changes(string destination, int number, DateTime time)
        {
            this.destination = destination;
            this.number = number;
            this.time = time;
        }

        internal class Program
        {
            public static void Main()
            {
                Train train621 = new Train(destination: "Tomsk", number: 126,
                    time: new DateTime(2023, 3, 9, 17, 45, 0));
                train621.Print();
                train621.Changes(destination: "Moscow", number: 621, time: new DateTime(2023, 3, 9, 14, 5, 0));
                train621.Print();
            }
        }
    }
}    