using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class Ficha : IFicha<int>
    {
        public List<int> values { get; set; }
        public Ficha(List<int> values)
        {
            this.values = values;
        }
        public int Value()
        {
            int valor = 0;
            foreach (var value in values)
            {
                valor += value;
            }
            return valor;
        }

        public override string ToString()
        {
            return $"{values[0]}, {values[1]}";
        }
    }
}
