using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sumDelete = 0;

            while (pokemonList.Count != 0)
            {
                int pokemonIndex = int.Parse(Console.ReadLine());
                int currentPokemon = 0;
                               

                if (pokemonIndex < 0)
                {
                    currentPokemon = pokemonList[0];
                    sumDelete += currentPokemon;

                    pokemonList[0] = pokemonList[pokemonList.Count - 1];
                }
                else if (pokemonIndex >= pokemonList.Count)
                {
                    currentPokemon = pokemonList[pokemonList.Count -1];
                    sumDelete += currentPokemon;

                    pokemonList[pokemonList.Count - 1] = pokemonList[0];
                }
                else
                {
                    currentPokemon = pokemonList[pokemonIndex];
                    pokemonList.RemoveAt(pokemonIndex);
                    sumDelete += currentPokemon;
                }

                for (int i = 0; i < pokemonList.Count; i++)
                {
                    if (pokemonList[i] <= currentPokemon)
                    {
                        pokemonList[i] = pokemonList[i] + currentPokemon;
                    }
                    else if (pokemonList[i] > currentPokemon)
                    {
                        pokemonList[i] = pokemonList[i] - currentPokemon;
                    }
                }             
                // Console.WriteLine(string.Join(" ", pokemonList));
            }

            Console.WriteLine(sumDelete);
        }
    }
}
