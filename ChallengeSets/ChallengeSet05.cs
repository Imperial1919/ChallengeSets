using System;
using System.Collections.Generic;

using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int output = ((startNumber / n) + 1) * n;
            return output;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

            foreach (Business Establishment in businesses)
            {
                if (Establishment.TotalRevenue <= 0)
                {
                    Establishment.Name = "CLOSED";



                }


            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Length == 0)
            {
                return false;
            }



            var answer = true;

            var check = numbers.OrderBy(num => num).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {



                if (numbers[i] != check[i])
                {
                    answer = false;
                }


            }
            return answer;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;


            }

            if (numbers.Length == null)
            {

                return 0;
            }

            int answer = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    answer += numbers[i];
                }





            }
            return answer;

        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";

            }

            if (words.Length == null)
            {
                return "";
            }



            var test = words.Aggregate(
    "", // start with empty string to handle empty list case.
    (current, next) => current + " " + next);
            return test.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null)
            {

                return new double[0];
            }
            else
            {

                return elements.Where((coordinate, index) => (index + 1) % 4 == 0).ToArray();
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var ans = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                
                var num1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var num2 = nums[j];

                    if (num1 + num2 == targetNumber)
                    {
                        ans = true;
                    }
                }
            }
                return ans;
            













        }
    }
}
    

