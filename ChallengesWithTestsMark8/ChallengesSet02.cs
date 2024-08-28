using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
             return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = vals.Length;
            if (count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                double min = double.MaxValue;
                double max = double.MinValue;
                foreach (var num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return min + max;
            }
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1 == null || str2 == null)
            {
                return 0;
            }
            else
            {
                if (str1.Length < str2.Length)
                {
                    return str1.Length;
                }
                else
                {
                    return str2.Length;
                }
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
            
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }
                return sum;
            }
            ;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    sum += num;
                }
                if (sum % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                long count = 0;
                for (long i = 0; i < number; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
                return count;
            }
            
        }
    }
}
