namespace SetCover
{
    internal class Program
    {
        public static List<int[]> ChooseSets(List<int[]> sets, List<int> universe)
        {
            List<int[]> selectedSets = new List<int[]>();

            while (universe.Count > 0)
            {
                int[] current = sets.OrderByDescending(set => set.Count(universe.Contains)).First();

                selectedSets.Add(current);
                sets.Remove(current);

                foreach (var i in current)
                {
                    universe.Remove(i);
                }
            }
            return selectedSets;
        }

        static void Main(string[] args)
        {
            var universe = new List<int> { 1, 2, 3, 4, 5 };
            int set = int.Parse(Console.ReadLine());
            var sets = new List<int[]>();

            for (int i = 0; i < set; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sets.Add(input);
            }

            var list = ChooseSets(sets, universe);

            foreach (var item in list)
            {
                Console.WriteLine($"{{{string.Join(", ", item)}}}");
            }
        }
    }
}