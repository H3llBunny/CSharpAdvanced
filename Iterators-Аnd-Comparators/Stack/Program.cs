namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackClass<string> stack = null;
            string command = Console.ReadLine();

            var numbers = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Skip(1).Select(x => x.Replace(",", "")).ToArray();
            stack = new StackClass<string>(numbers);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var token = input.Split();

                switch (token[0])
                {
                    case "Push":
                        var nums = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Skip(1).Select(x => x.Replace(",", "")).ToArray();
                        stack.Push(nums);
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (ArgumentException ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var num in stack)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}