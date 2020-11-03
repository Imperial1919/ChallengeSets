using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (c != 'c')
            {
                return false;


            }

            else
            {
                return true;
            }




        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 != 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 != 0)
            {
                return false;

            }

            else
            {
                return true;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {

                return false;
            }

            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null)
            {
                return 0;
            }
            if(numbers.Count() == 0)
            {
                return 0;
            }


            else
            {
                return numbers.Min() + numbers.Max();
            }





        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                int answer = str1.Length;
                return answer;
            }
            else
            {
                int answer2 = str2.Length;
                return answer2;
            }
        }

        public int Sum(int[] numbers)
        {
            var ans = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= numbers.Length)
                {
                    ans += numbers[i];
                }
            }
            return ans;
        }

        public int SumEvens(int[] numbers)
        {
            var ans = 0;
            if (numbers == null)
            {
                return 0;
            }

           

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ans += numbers[i];
                }
            }
            return ans;
        }
    


        public bool IsSumOdd(List<int> numbers)
        {
            int total = 0;
            if (numbers == null)
            {
                return false;
            }

            for (int i = 0;i < numbers.Count; i++)
            {

                total += numbers[i];

            }

            if(total % 2 == 0)
            {
                return false;
            }
             else
            {
                return true;
            }


        }
          
        

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var answer = 0;
          if(number <= 0)
            {

                return 0;
            }
            
            for(int i = 0;i < number;i++)
            {
                if (i % 2 != 0)
                {
                    answer++;
                }
               
               
            }
            return answer;
           


        }
    }
}