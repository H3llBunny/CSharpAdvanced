using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Word_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("text.txt"))
            {
                var wordsCounter = new Dictionary<string, int>();
                string[] words = File.ReadAllLines("words.txt");

                while (!reader.EndOfStream)
                {
                    var text = reader.ReadLine().ToLower(); ;
                    var punctuationRemover = new Regex(@"[-.,?!'""]");
                    text = punctuationRemover.Replace(text, "");
                    var split = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in split)
                    {
                        if (words.Contains(word))
                        {
                            if (wordsCounter.ContainsKey(word))
                            {
                                wordsCounter[word]++;
                            }
                            else
                            {
                                wordsCounter.Add(word, 1);
                            }
                        }
                    }
                }

                using (var writer = new StreamWriter("actualResults.txt"))
                {
                    foreach (var word in wordsCounter.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}