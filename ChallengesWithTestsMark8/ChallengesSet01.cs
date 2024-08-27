﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            if (minuend == 0 && subtrahend == 0)
            {
                return 0;
            }
            else
            {
                return minuend - subtrahend;
            }
        }

        public int Add(int number1, int number2)
        {
           if (number1 == 0 && number2 == 0)
            {
                return 0;
            }
            else
            {
                return number1 + number2;
            }
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            if (factor1 == 0 || factor2 == 0)
            {
                return 0;
            }
            else
            {
                return factor1 * factor2;
            }
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }

        }

        public string GetHey()
        {
            if (true)
            {
                return "HEY!";
            }
            
        }
    }
}
