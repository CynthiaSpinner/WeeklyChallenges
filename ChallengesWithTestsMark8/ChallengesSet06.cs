using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool possword = false;
            
            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if(ignoreCase == true)
            {
                word = word.ToLower();

                List<string> list = words.Select(x => x.ToLower()).ToList();    

                possword = list.Contains(word);
            }

            if (ignoreCase == false) 
            {
                possword = words.Contains(word);            
            }
            return possword;
        }

        public bool IsPrimeNumber(int num)
        {
            var prime = false;

            if(num >= 0) 
            {
                if(num % 2 != 0 && num % 3 != 0) 
                {
                    prime = true;
                }
            }

            if((num == 2) || (num == 3))
            {
                prime = true;
            }
            if(num ==1)
            {
                prime = false;
            }
            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool cindex;

            for(int i = 0; i < str.Length; i++)
            {
                cindex = true;

                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        cindex = false;
                    }
                }
                if (cindex == true)
                {
                    index = i;
                }              
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int num = 0;

            for(var i = 0; i < numbers.Length; i++)
            {
                int newnum = 1;

                for (var j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    newnum++;
                }
                if (newnum > num)
                {
                    num = newnum;
                    
                }
            }
            return num;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nine = new List<double>();

            if(elements == null || n <= 0 || n > elements.Count)
            {
                return nine.ToArray();
            }

            for(var i = n - 1; i < elements.Count; i += n)
            {
                nine.Add(elements[i]);
            }
            return nine.ToArray();
        }
    }
}
