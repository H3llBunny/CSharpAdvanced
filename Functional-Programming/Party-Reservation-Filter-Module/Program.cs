using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var guests = new List<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        var filters = new List<string>();

        string input = Console.ReadLine();

        while (input != "Print")
        {
            var tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];

            switch (command)
            {
                case "Add filter":
                    filters.Add(tokens[1] + " " + tokens[2]);
                    break;

                case "Remove filter":
                    filters.Remove(tokens[1] + " " + tokens[2]);
                    break;
            }

            input = Console.ReadLine();
        }

        foreach (var filter in filters)
        {
            var tokens = filter.Split(' ');
            string command = tokens[0];

            switch (command)
            {
                case "Starts":
                    guests = guests.Where(p => !p.StartsWith(tokens[2])).ToList();
                    break;

                case "Ends":
                    guests = guests.Where(p => !p.EndsWith(tokens[2])).ToList();
                    break;

                case "Length":
                    guests = guests.Where(p => p.Length != int.Parse(tokens[1])).ToList();
                    break;

                case "Contains":
                    guests = guests.Where(p => !p.Contains(tokens[1])).ToList();
                    break;
            }
        }

        if (guests.Any())
        {
            Console.WriteLine(string.Join(" ", guests));
        }
    }
}
