using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMALINOG_PDA
{
    public class Palindrome : IPDAChecking
    {
        Stack<char> charStack = new Stack<char>();
        int i;
        public string Checking(string text)
        {
            
            int middle = text.Length / 2;

            for (i = 0; i < middle; i++)
            {
                charStack.Push(text[i]);
            }

            if (text.Length % 2 != 0)
            {
                i++;
            }

            while (i < text.Length)
            {
                if (text[i] == charStack.Peek())
                {
                    charStack.Pop();
                }
                else
                {
                    return "Not a Palindrome!";
                }
                i++;
            }

            return "Text is a Palindrome!";
        }
    }
}
