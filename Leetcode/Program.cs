using System;
using System.Collections;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
        }

        public static bool IsValid(string s)
        {
            Stack parentheses = new Stack();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    parentheses.Push(c);
                }
                if (c == ')' || c=='}' || c == ']')
                {
                    if (isValidParentheses(parentheses, c))
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return parentheses.Count > 0 ? false : true;
        }

        public static bool isValidParentheses(Stack parentheses, char c)
        {

            if (parentheses.Count > 0)
            {
                if (c == ')')
                {
                    return (char)parentheses.Peek() == '(';
                }
                else if (c == '}')
                {
                    return (char)parentheses.Peek() == '{';
                }
                else
                {
                    return (char)parentheses.Peek() == '[';
                }
            }
            else
            {
                return false;
            }
        }
    }
}
