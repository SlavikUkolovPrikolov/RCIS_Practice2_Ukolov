using System;
using System.Text;
using System.Collections.Generic;

namespace UkolovVR
{
    internal class Program
    {
        public static void Main()
        {
            /* (1)
            int Entries(string a, string b)
            {
                StringBuilder substring1 = new StringBuilder(a);
                StringBuilder substring2 = new StringBuilder(b);
                int countOfEntries = 0;
                for (int i = 0; i < substring2.Length; ++i)
                {
                    for (int o = 0; o < substring1.Length; ++o)
                    {
                        if (substring2[i] == substring1[o])
                        {
                            countOfEntries++;
                        }
                    }
                }
                return countOfEntries;
            }
    
            string s = "zx";
            string j = "zzxxccYaHochuZaSfchikaSigrat";
            Console.WriteLine(Entries(s, j));
            */



            /* (2)
            List<int> candidates = new List<int>() {2, 5, 2, 1, 2};
            int target = 5;
            int total = 0;
            List<int> answer = new List<int>();
        
            for (int i = 0; i < candidates.Count; i++)
            {
                total = 0;
                answer.Clear();
                for (int j = 0; j < candidates.Count; j++)
                {
                    if (i != j)
                    {
                        total += candidates[j];
                        answer.Add(candidates[j]);
                    }
                    if (total > target)
                    {
                        break;
                    }
                    else if (total == target)
                    {
                        for (int k = 0; k < answer.Count; k++)
                        {
                            Console.Write($"{answer[k]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            */



            /* (3)
            bool Matches(int[] nums)
            {
                for (int i = 0; i < nums.Length; ++i)
                {
                    int countOfMatch = 0;
                    for (int j = 0; j < nums.Length; ++j)
                    {
                        if (nums[i] == nums[j])
                        {
                            countOfMatch++;
                        }
                        if (countOfMatch == 2)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            int[] numbers = new int[] {2, 5, 7, 0, 2};
            Console.WriteLine(Matches(numbers));
            */
        }
    }
}