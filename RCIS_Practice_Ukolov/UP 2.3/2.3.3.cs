using System;

namespace UkolovVR
{
    public class Calculation
    {
        public string calculationLine;
    
        public Calculation(string calculationLine)
        {
            this.calculationLine = calculationLine;
        }
    
        public void SetCalculationLine(string calculationLine)
        {
            this.calculationLine = calculationLine;
        }
    
        public void GetCalculationLine()
        {
            Console.WriteLine(calculationLine);
        }
    
        public void SetLastSymbolCalculationLine(string symbol)
        {
            calculationLine = calculationLine.Insert(calculationLine.Length, symbol);
            Console.WriteLine(calculationLine);
        }
    
        public void GetLastSymbol()
        {
            Console.WriteLine(calculationLine[calculationLine.Length - 1]);
        }
    
        public void DeleteLastSymbol()
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
            Console.WriteLine(calculationLine);
        }
    }

    internal class Program
    { 
        public static void Main()
        {
            Calculation text = new Calculation("Ukolov");
            text.GetCalculationLine();
            text.SetCalculationLine("Prikolov");
            text.GetCalculationLine();
            text.SetLastSymbolCalculationLine("V");
            text.GetLastSymbol();
            text.DeleteLastSymbol();
        }
    }
}  