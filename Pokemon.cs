using System;
using pooPokemonApp;




namespace pooPokemonApp;


    public class Pokemon
    {
        
        public Pokemon()
        {
            this.Nome = "";
            this.Descricao = "";
        }
        private String nome;
        public String Nome
        {
            get { return nome; }
            set {
                String texto = value.ToUpper();
                 nome = texto; 
                 }
        }

        private String descricao;
        public string Descricao
        {
            get { return this.descricao; }
            set {this.descricao = value.ToUpper();}
        }

        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descrição do Pokemon: " + this.Descricao);
        }
        
    }   
        


     

