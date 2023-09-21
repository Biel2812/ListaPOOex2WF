using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ02
{
    internal class Multiplicação
    {
        //atributos
        private int l1;
        private int a;

        //metodos 
        public void setAresta(int p)
        {
            l1 = p;
        }

        public int getAresta()
        {
            return l1;
        }

        public int getArea()
        {
            return a;
        }

        public void calcularArea()
        {
            a = l1 * l1;
        }
    }
}




