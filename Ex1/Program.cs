using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {

        static void Main(string[] args)
        {
            string str1 = "([]{})[]";
            string str2 = "([]]";
            string str3 = "([{ }])";
            string str4 = "([{";
            Console.WriteLine(CheckBrackets(str1));
            Console.WriteLine(CheckBrackets(str2));
            Console.WriteLine(CheckBrackets(str3));
            Console.WriteLine(CheckBrackets(str4));
            Console.ReadKey();
        }
        public static bool CheckBrackets(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                    continue;
                }
                if (c == ')' && stack.Peek() == '(')
                    stack.Pop();

                if (c == ']' && stack.Peek() == '[')
                    stack.Pop();
                if (c == '}' && stack.Peek() == '{')
                    stack.Pop();
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
