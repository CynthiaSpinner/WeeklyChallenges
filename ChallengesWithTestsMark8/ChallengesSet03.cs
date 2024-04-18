using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Where(x => x.Equals(false)).Any();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;

            for (int i = 0; i < password.Length; i++) 
            {
                if (char.IsUpper(password[i])) 
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))  
                { 
                    lower = true;
                }
                if (char.IsNumber(password[i]))
                {
                    number = true;
                }
                
            }
            if(upper == true && lower == true && number == true) 
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
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == null || divisor == null)
            {
                return 0;
            }
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int last = nums.Last();
            int first = nums.First();

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
           
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int word = 0; word < words.Length; word++)
            {
                words[word] = words[word].ToUpper();
               
            }
            
        }
    }
}
