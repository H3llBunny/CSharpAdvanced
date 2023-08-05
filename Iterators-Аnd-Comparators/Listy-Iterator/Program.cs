using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace ListyIteratorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var token = command.Split();

                switch (token[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(token.Skip(1).ToArray());
                        break;

                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;

                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }
                        break;

                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;

                    case "PrintAll":
                        foreach (var item in listyIterator)
                        {
                            Console.WriteLine(item + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}