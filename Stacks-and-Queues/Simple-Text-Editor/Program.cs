using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var textStack = new Stack<string>();
            textStack.Push(" ");

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);
                
                if(command == 1)
                {
                    text.Append(input[1]);
                    textStack.Push(text.ToString());
                }
                else if(command == 2)
                {
                    int eraseCount = int.Parse(input[1]);
                    text.Remove(text.Length - eraseCount, eraseCount);
                    textStack.Push(text.ToString());
                }
                else if(command == 3)
                {
                    int index = int.Parse(input[1]);

                    Console.WriteLine(text[index - 1]);
                }
                else if(command == 4 && textStack.Count > 0)
                {
                    if(textStack.Peek() == text.ToString() && textStack.Count > 2)
                    {
                        textStack.Pop();
                        text.Clear();
                        text.Append(textStack.Peek());
                    }
                    else if(textStack.Peek() == text.ToString() && textStack.Count == 1)
                    {
                        text.Clear();
                        text.Append(textStack.Peek());
                    }
                    else if(textStack.Peek() != text.ToString() && textStack.Count == 1)
                    {
                        text.Clear();
                    }
                    else if (textStack.Peek() == text.ToString() && textStack.Count > 1)
                    {
                        text.Clear();
                    }
                }
            }
        }
    }
}