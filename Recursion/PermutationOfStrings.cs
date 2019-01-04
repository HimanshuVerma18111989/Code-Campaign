using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class PermutationOfStrings
    {
        public void PermutationOfString(char[] input, char[] result, int[] count, int level)
        {
            if (level == input.Length)
            {
                foreach (char ch in result)
                {
                    Console.Write($"{ch},");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (count[i] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        result[level] = input[i];
                        count[i]--;
                        PermutationOfString(input, result, count, level + 1);
                        count[i]++;
                    }
                }
            }
        }
    }
}
