using System;
using System.Collections.Generic;
using System.Text;
using EX24poppo;


namespace EX24poppo
{
    public enum PokemonID
    {
        Poppo, Pigeon, Pidgeot, Koratta, Ratta
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<PokemonID, Pokemon> pokemonList = new Dictionary<PokemonID, Pokemon>();//基礎データ
            pokemonList.Add(PokemonID.Pidgeot, new Pokemon("Pidgiot", 0));
            pokemonList.Add(PokemonID.Pigeon, new Pokemon("Pigeon", 50, pokemonList[PokemonID.Pidgeot]));
            pokemonList.Add(PokemonID.Poppo, new Pokemon("Poppo", 12, pokemonList[PokemonID.Pigeon]));


        }
    }
}
