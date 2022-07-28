using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoAndDs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var result = isDigitIncreasing(7404);

            //Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
            //Console.WriteLine(LengthOfLongestSubstring("bbb"));
            //Console.WriteLine(LengthOfLongestSubstring("pwwkew"));
            var reversedString = ReverseString("abcdef");
            int[] numbers = { 1, 3, 4 };
            var findMissing = FindMissing(numbers);
            Console.WriteLine(reversedString);
            Console.WriteLine(LengthOfLongestSubstring("aab")); // in progress
            Console.WriteLine(findMissing);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            var len = 0;
            List<int> counts = new(){0};
            StringBuilder a = new StringBuilder();
            foreach (char i in s)
            {
                if (a.ToString().Contains(i))
                {
                    counts.Add(len);
                    len = 0;
                    a.Clear();
                    continue;
                }
                len++;
                counts.Add(len);
                a.Append(i);
            }
            return counts.Max();
        }
        static string ReverseString(string i)
        {
            //length of input string
            int len = i.Length;
            int position = len - 1;
            StringBuilder reversed = new StringBuilder();
            for (int j = 0; j < len; j++, position--)
                reversed.Append(i[position]); //store reversed string inside variable
            return reversed.ToString();
        }

        static int FindMissing(int[] numbers)
        {
            int len = numbers.Length;
            int currentNumber = numbers[0];
            for (int j = 0; j < len; j++)
            {
                if (numbers[j] != currentNumber)
                    return numbers[j] - 1;
                currentNumber++;
            }
            return -1;
        }
    }
}
