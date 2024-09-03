using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
            
           
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum % 2 != 0;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach (var character in password)
            {
                if (char.IsUpper(character))
                {
                    hasUpper = true;
                }
                if (char.IsLower(character))
                {
                    hasLower = true;
                }
                if (char.IsDigit(character))
                {
                    hasNumber = true;
                }
            }
            return hasUpper && hasLower && hasNumber;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];

            
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
            
        }

        public int[] GetOddsBelow100()
        { 
            List<int> odds = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }
            return odds.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
