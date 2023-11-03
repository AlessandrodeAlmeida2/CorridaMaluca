using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Corredor
    {
        private static Random rnd = new Random();
        public Corredor() 
        {
            this.Nome = "";
        }

        public Corredor(String nome)
        {
            this.Nome = nome;
        }
        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set 
            {
                this.nome = value;
                if (value.Length > 1) this.nome = value[0].ToString();
                if (value.Length == 0) this.nome = "d";
            }
        }


        public int Correr()
        {
            
            return rnd.Next(0, 10);
        }
    }
}
