using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class Reglas : IRegla<int>
    {

        public List<IFicha<int>> PiezasValidas(List<IFicha<int>> piezas, IBoard<int> board)
        {
            List<IFicha<int>> piezasValidas = new List<IFicha<int>>();
            foreach (var pieza in piezas)
            {
                if (JugadaValida(pieza,board)) piezasValidas.Add(pieza);
            }
            return piezasValidas;
        }
        public bool JugadaValida(IFicha<int> pieza, IBoard<int> board)
        {
            if ( board.valoresActuales.Item1 == -1 ) return true;
            if (pieza.values[1] == board.valoresActuales.Item1 || pieza.values[0] == board.valoresActuales.Item1 ||
                pieza.values[1] == board.valoresActuales.Item2 || pieza.values[0] == board.valoresActuales.Item2)
                return true;
            else return false;
        }
    }
}
