using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class RomanNumerals
    {
        static Dictionary<int, string> dicRom = new Dictionary<int, string>
        { 
            { 1000, "M" },  { 900, "CM" },  { 500, "D" },  { 400, "CD" },  { 100, "C" },
            { 90 , "XC" },  { 50 , "L" },  { 40 , "XL" },  { 10 , "X" },
            { 9  , "IX" },  { 5  , "V" },  { 4  , "IV" },  { 1  , "I" } 
        };

        public static string ToRoman(int n)
        {
            return dicRom
                .Where(x => n >= x.Key)
                .Select(x => x.Value + ToRoman(n - x.Key))
                .First();

            //var result = new StringBuilder();

            //int size = n.ToString().Length;
            //int[] numbers = new int[size];
            //int i = 0;

            //while (n != 0)
            //{
            //    numbers[i] = (n % 10);
            //    n /= 10;
            //    i++;
            //}
            //Array.Reverse(numbers);
            
            //for (int j = 0; j < numbers.Length; j++)
            //{                
            //    result.Append(SwitchNumber(size, numbers[j]));
            //    size--;
            //}
            
            //return result.ToString();
        }

        public static int FromRoman(string romanNumeral)
        {
            return romanNumeral.Length == 0 ? 0 : dicRom
                .Where(x => romanNumeral.StartsWith(x.Value))
                .Select(x => x.Key + FromRoman(romanNumeral.Substring(x.Value.Length)))
                .First();
        }

        public static string SwitchNumber(int s, int n)
        {
            switch (s)
            {
                case 4:
                    return new string('M', n);
                case 3:
                    if (n < 4)
                        return new string('C', n);
                    if (n == 4)
                        return "CD";
                    if (n >= 5 && n < 9)
                        return ("D" + new string('C', n - 5));
                    if (n == 9)
                        return "CM";
                    break;
                case 2:
                    if (n < 4)
                        return new string('X', n);
                    if (n == 4)
                        return "XL";
                    if (n >= 5 && n < 9)
                        return ("L" + new string('X', n - 5));
                    if (n == 9)
                        return "XC";
                    break;
                case 1:
                    if (n < 4)
                        return new string('I', n);
                    if (n == 4)
                        return "IV";
                    if (n >= 5 && n < 9)
                        return ("V" + new string('I', n - 5));
                    if (n == 9)
                        return "IX";
                    break;
            }
            return "";
        }
    }
}
