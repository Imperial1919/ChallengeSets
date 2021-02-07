using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            //List<string> test = new List<string>();

            //test.Add(words.ToString());

            //bool outputfalse = test.Any(item => test.Contains(word));

            //return outputfalse;
            bool RandomBool = false;
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                word = word.ToLower();
                List<string> New_List = words.Select(x => x.ToLower()).ToList();
                RandomBool = New_List.Contains(word);

                
            }
            if(ignoreCase == false)
            {
                RandomBool = words.Contains(word);
            }
            return RandomBool;
        }

        public bool IsPrimeNumber(int num)
        {
          
            bool answer = false;
            var number = 0;

            if(num >= 0) { 
            if(num % 2 != 0 && num % 3 != 0)
                {
                    answer = true;
                }

            }
            if((num == 2 ) || (num == 3))
            {
                answer = true;
            }
            if(num == 1)
            {
                answer = false;
            }

            return answer;


            }


        public int IndexOfLastUniqueLetter(string str)
        {


            int index = -1;

            bool tester;

            for (int i = 0; i < str.Length; i++)
            {
                tester = true;

                for (int i2 = 0; i2 < str.Length; i2++)
                {
                    if(str[i] == str[i2] && i != i2)
                    {
                        tester = false;
                    }
                }

                if (tester == true)
                {
                    index = i;
                }

             
            }
            return index;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for(int i = 0;i < numbers.Length; i++)
            {
                int currentCount = 1;
                for(int j = i + 1;j < numbers.Length; j++)
                {
                    if(numbers[i] != numbers[j])
                    {
                        break;
                    }

                    currentCount++;

                }
                if(currentCount > count)
                {
                    count = currentCount;
                }


            }

            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> test = new List<double>();
            List<int> test2 = new List<int>();
            if (elements == null || n < 0)
            {
                var test1 = new double[0];
                return test1;
            }


            for (int elementcounter = 0;elementcounter < elements.Count;elementcounter++)
            {

             

                if (elements[elementcounter] % n == 0 )
                {
                    test.Add(elements[elementcounter]);
                }

                if (n < 0)
                {
                    break;
                }


              
               

                
            

            }

          var experiment =  test.ToArray();
            return experiment;
        }
    }
}
