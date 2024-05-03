using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(var indexer = 0; indexer < businesses.Length; indexer++ )
            {
                if (businesses[indexer].TotalRevenue == 0)
                {
                    businesses[indexer].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for(var i = 1; i < numbers.Length; i++) 
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                                               
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int result = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    result += numbers[i];
                }
                
            }
            return result;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length == 0)
            {
                return "";
            }

            string complete = "";

           foreach(string word in words) 
           {
               if(word.Trim().Length > 0)
                {
                    complete += word.Trim() + " "; 
                }
           }
           if(complete.Length == 0)
           {
               return "";
           }
           complete = complete.Trim();
           complete += "."; 
           return complete;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if(elements == null || elements.Count == 0)
            { 
                return new double[0]; 
            }
            List<double> result = new List<double>();
            for(var i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++) 
            {
                for(int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[j] + nums[i] == targetNumber) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
