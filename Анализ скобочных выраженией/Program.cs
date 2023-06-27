using System;
using System.Collections.Generic;
namespace Analysis
{
    public class Program
    {
        public static bool IsCorrectString(string str)
        {
            var bracketsDict = new Dictionary<char, char>();
            bracketsDict['['] = ']';
            bracketsDict['('] = ')';
            bracketsDict['<'] = '>';

            var stack = new Stack<char>();

            foreach (var symbol in str)
            {
                if (bracketsDict.ContainsKey(symbol)) stack.Push(symbol);
                else if (bracketsDict.ContainsValue(symbol))
                {
                    if (stack.Count == 0 || bracketsDict[stack.Pop()] != symbol) return false;
                }
                else return false;
            }
            return stack.Count == 0;
        }
        
        static void Main()
        {

        }
    }
}