using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Pessoa
    {
        private string nome;
        private int rg;

        public Pessoa ()
        {

        }

        public Pessoa(string nome, int rg)
        {
            this.nome = nome;
            this.rg = rg;
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public int RG
        {
            set { rg = value; }
            get { return rg; }
        }

        public void print()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("RG: {0}", rg);
            Console.WriteLine("=======================");
        }
    }
}
