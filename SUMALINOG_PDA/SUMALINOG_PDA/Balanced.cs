using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALINOG_PDA
{
    public class Balanced : IPDAChecking
    {
        Stack<char> charStack;
        int count;
        string output;
        public string Checking(string text)
        {
            count = 0;
            charStack = new Stack<char>();

            foreach (var chara in text)
            {
                switch(chara)
                {
                    case '(':
                        charStack.Push('(');
                        break;
                    case '{':
                        charStack.Push('{');
                        break;
                    case '[':
                        charStack.Push('[');
                        break;
                    case ')':
                        if (charStack.Peek() == '(')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return "Not Balanced! Missing a Symbol";
                        }
                        break;
                    case '}':
                        if (charStack.Peek() == '{')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return "Not Balanced! Missing a Symbol";
                        }
                        break;
                    case ']':
                        if (charStack.Peek() == '[')
                        {
                            charStack.Pop();
                        }
                        else
                        {
                            return "Not Balanced! Missing a Symbol";
                        }
                        break;
                }
            }

            if (charStack.Count() > 0)
            {
                output = "Not Balanced! Missing Symbols: ";
                while (charStack.Count != 0)
                {
                    if (charStack.Peek() == '(')
                    {
                        output += ") ";
                        charStack.Pop();
                    }
                    else if (charStack.Peek() == '{')
                    {
                        output += "} ";
                        charStack.Pop();
                    }
                    else if (charStack.Peek() == '[')
                    {
                        output += "] ";
                        charStack.Pop();
                    }
                }
                return output;
            }

            return "Everything is Balanced! Congratulations";
        }
    }
}
