using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>
            {
                str1.Length,
                    str2.Length,
                        str3.Length,
                            str4.Length
            };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>()
            {
                number1,
                    number2,
                        number3,
                            number4
            };

            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }
                        
            if (sideLength1 + sideLength2 <= sideLength3)
            {
                return false;
            }

            else if(sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }

            else if(sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsStringANumber(string input)
        {
            var num = double.TryParse(input, out double number);

            return num;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
           var amount = objs.Length;
            var majority = (amount / 2) + 1;

            var count = 0;
            foreach (var obj in objs ) 
            {
                if (obj == null)
                {
                    count++;
                }

            }
            if (count >= majority)
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
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var num = numbers.Where(x => x % 2 == 0);
            
            
            if (num.Count() == 0)
            {
                return 0;
            }
            else
            {
                return num.Average();
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int fact = 1;

            for (int i = 1; i <= number; i++) 
            {
                fact = fact * i;
            }
            return fact;

           
        }
    }
}
