using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        public static Pessoa[] pessoas = new Pessoa[5];
        public static int indice = 0;

        static void Main(string[] args)
        {

            char op;

            do
            {
                Console.WriteLine("\n|==================================|");
                Console.WriteLine("|CADASTRO DE PESSOAS               |");
                Console.WriteLine("|(1) Cadastrar nova pessoa         |");
                Console.WriteLine("|(2) Listar todas as pessoas       |");
                Console.WriteLine("|(3) Pesquisar pessoa pelo rg      |");
                Console.WriteLine("|(4) Excluir pessoa                |");
                Console.WriteLine("|(5) SAIR                          |");
                Console.WriteLine("|==================================|");
                op = Convert.ToChar(Console.ReadLine());
                //
                switch(op)
                {
                    case '1': CadastroPessoa(); break;
                    case '2': ListarPessoas(); break;
                    case '3': Pesquisar(); break;
                    case '4': Excluir(); break;
                    case '5': break;
                    default: Console.WriteLine("Opção Inválida!"); break;
                }

            } while (op != '5');

    }
        public static void CadastroPessoa()
        {

            if(indice < pessoas.Length)
            {
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o RG: ");
                int rg = Convert.ToInt32(Console.ReadLine());
                pessoas[indice] = new Pessoa(nome, rg);
                indice++;
                Console.Clear();
            } else
            {
                Console.WriteLine("Cadastro Completo");
                Console.ReadKey();
                Console.Clear();
            }

        }

        public static void ListarPessoas()
        {
            for(int i = 0; i < pessoas.Length; i++)
                if(pessoas[i] != null)
            {
                pessoas[i].print(); 
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static void Pesquisar()
        {
            int rg;
            Pessoa p = new Pessoa();

            Console.WriteLine("Digite o RG para pesquisar: ");
            rg = Convert.ToInt32(Console.ReadLine());
            bool achou = false;
            int i = 0;

                while ((!achou) & (i < pessoas.Length))
                {
                if (pessoas[i] != null)
                {
                    if(pessoas[i].RG == rg)
                    {
                        achou = true;
                    }
                    else
                    {
                        i += 1;
                    }
                } else { break; }
                }

            if (achou == true)
            {
                pessoas[i].print();
                Console.ReadLine();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Não encontrado.");
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void Excluir()
        {
            Console.WriteLine("Digite o RG para pesquisar: ");
            int rg = Convert.ToInt32(Console.ReadLine());
            bool achou = false;
            int i = 0;

            while ((!achou) & (i < pessoas.Length))
            {
                if (pessoas[i] != null)
                {
                    if (pessoas[i].RG == rg)
                    {
                        achou = true;
                    }
                    else
                    {
                        i += 1;
                    }
                }
                else { Console.WriteLine("RG não encontrado!"); Console.ReadLine(); break; }
            }

            if (achou == true)
            {
                pessoas[i].print();
                Console.WriteLine("Deseja excluir pessoa? (S/N)");
                char op = Convert.ToChar(Console.ReadLine());

                switch(op)
                {
                    case 's':
                        {
                            pessoas[i] = null;
                            Console.WriteLine("Pessoa excluída com sucesso!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 'n': Console.Clear(); break;
                    default: Console.WriteLine("Opção inválida!"); Console.ReadLine(); break;
                }

            }

            else
            {
                Console.Clear();
            }
        }
    }
}