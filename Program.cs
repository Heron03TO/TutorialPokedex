using System;
using pooPokemonApp;



namespace pooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon p = new Pokemon();
            p.Nome = "Bulbasauro";
            p.Descricao = "Bulbasauro é um pokemon tipo planta";
            p.ExibirDadosPokemon();
         

            Pokemon p1 = new Pokemon();
            p1.Nome = "Pikachu";
            p1.Descricao = "Pikachu é um pokemon tipo elétrico";
            p1.ExibirDadosPokemon();
            Console.ReadKey();
            
        }





    }



}
