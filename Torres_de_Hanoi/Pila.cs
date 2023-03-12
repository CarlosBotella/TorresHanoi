using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; } = new List<Disco>();

        /* TODO: Implementar métodos */
        public Pila()
        {
            this.Size = 0;
            this.Top = 0;

        }

        public Pila(int n)
        {
            this.Size = n;
            for (int i = n; i > 0; i--)
            {
                Disco disc = new Disco();
                disc.Valor = i;
                this.Elementos.Add(disc);
            }
            this.Top = 1;

        }

        public void push(Disco d)
        {
            this.Elementos.Add(d);
            this.Size++;
            this.Top = this.Elementos[this.Size - 1].Valor;
        }

        public Disco pop(){
            Disco disc = this.Elementos[this.Size - 1];
            this.Elementos.Remove(disc);
            this.Size--;
            this.Top = 0;
            if (this.Size != 0)
            {
                this.Top = this.Elementos[this.Size - 1].Valor;
            }
            return disc;
        }





        public bool isEmpty()
        {
            if (this.Size == 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
