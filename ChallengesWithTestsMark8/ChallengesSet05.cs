using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int next = startNumber + 1;
            while (next % n != 0)
            {
                next++;
            }

            return next;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalExpenses >= business.TotalRevenue)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
                return false;
            if (numbers.Length == 1)
                return true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                    return false;
            }

            return true;
        }


        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)

                return 0;

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }
            var sentence = new List<string>();
            foreach (var word in words)
            {
                if (word != " ")
                {
                    var trimmed = word.Trim();
                    sentence.Add(trimmed);
                }
            }

            var answer = string.Join(" ", sentence).Replace("  ", " ").Trim();
            if (answer.Length == 0)
            {
                return "";
            }

            return answer + ".";
            
        }
        
        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4)
                return new double[0];

            List<double> result = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }


        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)

        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)

                        return true;
                }
            } 
            return false;
        }
        
    }
}