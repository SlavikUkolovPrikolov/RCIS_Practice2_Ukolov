using System;

namespace UkolovVR
{
    internal class Program
    { 
        public static void Main()
        {
            string romanNums = "DCXXI";
            int result = 0;
            for (int i = 0; i < romanNums.Length; i++)
            {
                if (romanNums[i] == 'I')
                {
                    if (i < romanNums.Length - 1 && romanNums[i + 1] == 'V')
                    {
                        result += 4;
                        i++;
                    }
                    else if (i < romanNums.Length - 1 && romanNums[i + 1] == 'X')
                    {
                        result += 9;
                        i++;
                    }
                    else
                    {
                        result += 1;
                    }
                }
                else if (romanNums[i] == 'V')
                {
                    result += 5;
                }
                else if (romanNums[i] == 'X')
                {
                    if (i < romanNums.Length - 1 && romanNums[i + 1] == 'L')
                    {
                        result += 40;
                        i++;
                    }
                    else if (i < romanNums.Length - 1 && romanNums[i + 1] == 'C')
                    {
                        result += 90;
                        i++;
                    }
                    else
                    {
                        result += 10;
                    }
                }
                else if (romanNums[i] == 'L')
                {
                    result += 50;
                }
                else if (romanNums[i] == 'C')
                {
                    if (i < romanNums.Length - 1 && romanNums[i + 1] == 'D')
                    {
                        result += 400;
                        i++;
                    }
                    else if (i < romanNums.Length && romanNums[i + 1] == 'M')
                    {
                        result += 900;
                        i++;
                    }
                    else
                    {
                        result += 100;
                    }
                }
                else if (romanNums[i] == 'D')
                {
                    result += 500;
                }
                else if (romanNums[i] == 'M')
                {
                    result += 1000;
                }
            }
        Console.WriteLine(result);
        }
    }
}  