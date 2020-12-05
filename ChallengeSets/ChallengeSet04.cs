using System;
using System.Linq;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            int OddSum = numbers.ToList().Where(i => i % 2 != 0).Sum();
            int EvenSum = numbers.ToList().Where(i => i % 2 == 0).Sum();
            int answer = 0;
            for(int i = 0;i <= numbers.Length; i++)
            {
                return EvenSum - OddSum;


                
            }

            return answer;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arrofstrings = new string[] { str1, str2, str3, str4 };

            var shorteststring = arrofstrings.OrderBy(str => str.Length).FirstOrDefault();

            return shorteststring.Length;



        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arrayofvalues = new int[] { number1, number2, number3, number4 };

            var smallestvalue = arrayofvalues.Min();

            return smallestvalue;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           
                biz.Name = "TrueCoders";


            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if (sideLength1 > 0 & sideLength2 > 0 && sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1 )
            {
                return true;
            

            }
             else
            {
                return false;
            }
     
        }

        public bool IsStringANumber(string input)
        {
          
            decimal randII = 1;
           
            var test2 = decimal.TryParse(input, out randII);
            return test2;
          
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
          
            int numberofnulls = 0;
            int numberofvalues = 0;
            var objectlength = objs.Length / 2;

            foreach (object test in objs)
            {
              
              
                if(test == null)
                {
                    numberofnulls++;
                 
                }

              

                
               



            }
            if(numberofnulls > objectlength)
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
         
            double sumcounter = 0;
            double sum = 0;
            
            if(numbers == null)
            {
                return 0;
            }
            
            for(int i = 0;i < numbers.Length; i++)
            { 

                if (numbers[i] % 2 == 0)
                {
                    sumcounter++;
                    sum += numbers[i];

                }               
            }
          if(sumcounter == 0 )
            {
                return 0;
            }   
          
            return sum / sumcounter;      
        }
        public int Factorial(int number)
        {

            int count = 1;
            int result = 1;
            

            while(count < number)
            {
                count++;
                result *= count;


            }
            return result;
        }
    }
}
