namespace PokemonTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var trainerList = new List<Trainer>();

            while ((input = Console.ReadLine()) != "Tournament")
            {
                var token = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = token[0];
                string pokemonName = token[1];
                string element = token[2];
                int health = int.Parse(token[3]);
                var pokemon = new Pokemon(pokemonName, element, health);

                if (trainerList.Any(x => x.Name == trainerName))
                {
                    var matchingTrainer = trainerList.Find(x => x.Name == trainerName);
                    matchingTrainer.PokemonCollection.Add(pokemon);
                }
                else
                {
                    var trainer = new Trainer(trainerName, 0, new List<Pokemon>());
                    trainerList.Add(trainer);
                    trainer.PokemonCollection.Add(pokemon);
                }
            }

            string givenElement;

            while ((givenElement = Console.ReadLine()) != "End")
            {
                ApplyElementEffect(trainerList, givenElement);
            }

            var orderedTrainerList = trainerList.OrderByDescending(x => x.NumberOfBadges);

            foreach (var trainer in orderedTrainerList)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
            }
        }

        public static void ApplyElementEffect(List<Trainer> trainers, string element)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.PokemonCollection.Any(x => x.Element == element))
                {
                    trainer.NumberOfBadges += 1;
                }
                else
                {
                    foreach (var pokemon in trainer.PokemonCollection)
                    {
                        pokemon.Health -= 10;
                    }

                    List<Pokemon> newPokemonCollection = new List<Pokemon>(trainer.PokemonCollection.Where(x => x.Health > 0));
                    trainer.PokemonCollection.Clear();
                    trainer.PokemonCollection = newPokemonCollection;
                }
            }
        }
    }
}