using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pilha_dinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            this.anterior = null;
        }

        public void setAnterior(Livro anterior)
        {
            this.anterior=anterior;
        }
        public Livro getAnterior()
        {
            return this.anterior;
        }

        public string getTitutlo()
        {
            return this.titulo;
        }

        public override string? ToString()
        {
            return "\n\nTítulo do livro: " + this.titulo ;
        }
    }
}
