//  "()"              =>  true
//  ")(()))"          =>  false
//  "("               =>  false
//  "(())((()())())"  =>  true

using System;
using System.Collections.Generic;

namespace Katas
{
    public class Kata_5_1
    {
        public static bool ValidParentheses(string input)
        {
            List<char> listChars = new List<char>();
            if(String.IsNullOrEmpty(input)) return false;

            for(int i = 0, listIndex = 0; i < input.Length; i++, listIndex++)
            {
                if((input[i] != ')' && input[i] != '('))
                {
                    listIndex--;
                    continue;
                }

                if (input[0] == ')' || input.Length == 1 || (input[i] == ')' && listChars.Count == 0)) 
                    return false;

                if (input[i] == '(')
                {
                    listChars.Add(input[i]);
                }
                else   // )
                {
                    if (listChars.Count == 1)
                    {
                        if (listChars[0] == '(')
                        {
                            listChars.RemoveAt(0);
                            listIndex = -1;
                        }
                        else return false;
                    }
                    else if (listChars.Count > 1)
                    {
                        if (listChars[listIndex - 1] == '(')
                        {
                            listChars.RemoveAt(listIndex - 1);
                            listIndex -= 2;
                        }
                        else return false;
                    }                    
                }
            }
            if (listChars.Count == 0) return true;
            return false;
        }
    }
}
