using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return false;
            }

            foreach (bool a in vals)
            {
                if (a == false)
                {
                    return true;
                }
            }

            return false;
        }


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return false;
            }

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }

            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lower = 0;
            var upper = 0;
            var number = 0;
            foreach (var c in password)
            {
                if (char.IsUpper(c))
                {
                    upper++;
                }

                if (char.IsLower(c))
                {
                    lower++;
                }

                if (char.IsNumber(c))
                {
                    number++;
                }
            }
            
            if(lower > 0 && upper > 0 && number > 0)
                
            {
                return true;
            }
            return false;
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
            {  return 0;} 
            return  dividend / divisor;
        }
        

        public int LastMinusFirst(int[] nums)
        {
           return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        { 
            var odds = new List<int>();
            var nums = new int[100];
            for (int i = 0; i < 100; i++)
            {
                nums[i] = i;
            }
            
            foreach (var num in nums)
            {
                if (num % 2 != 0)
                {
                    odds.Add(num);
                }
            }
            var answer = odds.ToArray();
            return answer;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++) 
                words[i] = words[i].ToUpper();
        }
    }
}
