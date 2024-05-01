using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_dinamica
{
    internal class PilhaLivro
    {
        Livro topo;

        public PilhaLivro()
        {
            this.topo = null;
        }

        public void push(Livro aux)
        {
            if(vazia() == true)
            {
                this.topo = aux;
            }else
            {
                aux.setAnterior(topo);
                this.topo = aux;
            }
        }

       

        bool vazia()
        {
            if (topo == null)
                return true;
            else
                return false;
        }

        public void print()
        {
            Livro aux = topo;
            if (vazia())
            {
                Console.WriteLine("Impossível impressão, pilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da Impressão!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
        }

        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine("Impossível remover, pilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            else
            {
                this.topo = this.topo.getAnterior();
            }
        }

        public void searchBook()
        {
            if (vazia() == true)
            {
                Console.WriteLine("Impossível buscar, pilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Digite o titulo do livro que deseja buscar: ");
                int count = 0;
                string search = Console.ReadLine();
                Livro atual = topo;
                string comp;
                do
                {
                    comp = atual.getTitutlo();
                    bool sh = search.Equals(comp);
                    if (sh == true)
                    {
                        count++;
                    }
                    atual = atual.getAnterior();
                    
                }while (atual != null);

                if (count == 0)
                {
                    Console.WriteLine($"O livro {search} não aparece na pilha");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"O livro {search} aparece {count} vez(es) na pilha");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadLine();
                }
            }
        }
    }
}
