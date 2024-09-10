using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
           int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
            return sum;
            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length };
            int shortest = lengths[0];
            foreach (int length in lengths)
            {
                if (length < shortest)
                {
                    shortest = length;
                }
            }
            return shortest;
            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            int smallest = numbers[0];
            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }
            return smallest;
            
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            double number;
            return double.TryParse(input, out number);


           
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }
            if (nullCount > objs.Length / 2)
            {
                return true;
            }
            return false;
            
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int evenCount = 0;
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                    sum += num;
                }
            }
            if (evenCount == 0)
            {
                return 0;
            }
            return (double)sum / evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
           
            
        }
    }
}
