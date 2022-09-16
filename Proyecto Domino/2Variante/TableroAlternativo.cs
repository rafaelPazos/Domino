using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class TableroAlternativo : IBoard<int>
    {
        public (int, int) valoresActuales { get; set; }
        public List<string> cabezaJugada { get; set; }
        public TableroAlternativo()
        {
            valoresActuales = new(-1, -1);
            cabezaJugada = new List<string>();
            cabezaJugada.Add("");
            cabezaJugada.Add("");
        }

        public void Actualizar(IFicha<int> ficha)
        {
            (int, int) valores;
            if (valoresActuales.Item1 == -1)
            {
                valores.Item1 = ficha.values[0];
                valores.Item2 = ficha.values[1];
                valoresActuales = valores;
            }
            else if ((valoresActuales.Item1 % 2 == 0) && (ficha.values[0] % 2 == 0) || (valoresActuales.Item1 == ficha.values[0]))
            {
                valores.Item1 = ficha.values[1];
                valores.Item2 = valoresActuales.Item2;
                valoresActuales = valores;
                cabezaJugada[cabezaJugada.Count - 1] = "izquierda"+valores.Item1.ToString();
                cabezaJugada.Add("");
            }
            else if ((valoresActuales.Item1 % 2 == 0) && (ficha.values[1] % 2 == 0) || (valoresActuales.Item1 == ficha.values[1]))
            {
                valores.Item1 = ficha.values[0];
                valores.Item2 = valoresActuales.Item2;
                valoresActuales = valores;
                cabezaJugada[cabezaJugada.Count - 1] = "izquierda"+valores.Item1.ToString();
                cabezaJugada.Add("");
            }
            else if ((valoresActuales.Item2 % 2 == 0) && (ficha.values[0] % 2 == 0) || (valoresActuales.Item2 == ficha.values[0]))
            {
                valores.Item1 = valoresActuales.Item1;
                valores.Item2 = ficha.values[1];
                valoresActuales = valores;
                cabezaJugada[cabezaJugada.Count - 1] = "derecha"+valores.Item2.ToString();
                cabezaJugada.Add("");
            }
            else if ((valoresActuales.Item2 % 2 == 0) && (ficha.values[1] % 2 == 0) || (valoresActuales.Item2 == ficha.values[1]))
            {
                valores.Item1 = valoresActuales.Item1;
                valores.Item2 = ficha.values[0];
                valoresActuales = valores;
                cabezaJugada[cabezaJugada.Count - 1] = "derecha"+valores.Item2.ToString();
                cabezaJugada.Add("");
            }
        }

        public override string ToString()
        {
            return $"{valoresActuales.Item1}, {valoresActuales.Item2}";
        }
    }
}
