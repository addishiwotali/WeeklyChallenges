using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evenSum = 0;
            var oddSum = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                       evenSum += numbers[i]; 
                }

                if (numbers[i] % 2 != 0)
                {
                    oddSum += numbers[i];
                }
            }
            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var sl1 = str1.Length;
            var sl2 = str2.Length;
            var sl3 = str3.Length;
            var sl4 = str4.Length;
            

            if (sl1 <= sl2 && sl1 <= sl3 && sl1 <= sl4)
            {
                return sl1;
            }
            
            if (sl2 <= sl1 && sl2 <= sl3 && sl2 <= sl4)
            {
                return sl2;
            }
            if(sl3 <= sl1 && sl3 <= sl2 && sl3 <= sl4)
            { 
                return sl3;
            }
            else
            {
                return sl4;
            }
            
        }
        

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            if (number1 <=number2 && number1 <= number3 && number1 <= number4)
            { 
                    return number1;
            }

            if (number2 <= number1 && number2 <= number3 && number2 <=number4)
            {
                return number2;
            }

            if (number3 <=number1 && number3 <= number2 && number3 <= number4)
            {
                return number3;
            }

            else
            {
                return number4;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3 <= sideLength2 ||
                sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
        

        public bool IsStringANumber(string input)
        {
            var canParse = double.TryParse(input, out var number);
            return canParse;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var sumNull = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    sumNull++;
                }
            }
            var half = objs.Length / 2;

            if (sumNull > half)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            double evenSum = 0;
            double sumCount = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                    sumCount++;
                }
            }

            if (sumCount == 0)
            {
                return 0;
            }
            
            double average = evenSum / sumCount;
            return average;
            
        }
        

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int answer = 1;

            for (int i = 1; i <= number; i++)
            {
                answer *= i;
            }
            return answer;
        }
    }
}
