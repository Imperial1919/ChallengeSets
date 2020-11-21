using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            
            
           
               var test = Array.Exists(vals, element => element == false);

            return test;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {


            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            bool isodd = true;
            bool conditional;
            var sum = 0;           

            foreach (int element in numbers)
            {
                
                var boolean = numbers.Sum(x => x % 2);
                


                if(boolean % 2 != 0)
                {
                    return true;
                }
                if(boolean % 2 == 0)
                {
                    return false;
                }

              
             


            }
            return isodd;


        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
       
          
        
            int up = 0;
            int low = 0;
            int digit = 0;
            


            foreach (char letter in password)
            {
                if (char.IsUpper(letter) && up == 0 )
                {

                    up++;
                   


                }
               
                

            }

            foreach(char letter in password)
            {
                 if(char.IsLower(letter) && low == 0)
                {
                    low++;

                }
            }

            foreach(char letter in password)
            {
                if(char.IsDigit(letter) && digit == 0)
                {
                    digit++;
                }

            }


            int result = up + low + digit;

            if(result == 3)
            {
                return true;
            }

            else
            {
                return false;
            }
            
        
            

         
         
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            var LastLetter = val.Length - 1;
            return val[LastLetter];
            
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
          
            if(divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
           
           
        }

        public int LastMinusFirst(int[] nums)
        {


            var lastChar = nums.Length - 1;
            var answer = nums[lastChar] - nums[0];
            return answer;
            
        }
        public int[] GetOddsBelow100()
        {

            List<int> test = new List<int>();
          for(int i = 0;i < 100; i++)
            {
                if(i % 2 != 0) {
                    test.Add(i);
                    
                }
                

            }
            return test.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int letter = 0; letter < words.Length;letter++)
            {
                words[letter] = words[letter].ToUpper();
            }
        }
    }
}
