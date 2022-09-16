using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class QuienGano : IQuienGano<int>
    {
        public IPlayer<int> Ganador(List<IPlayer<int>> jugadores, IRegla<int> reglas, IBoard<int> board, IScore<int> score)
        {
            /*for (int i = 0; i < jugadores.Count; i++)
            {
                if (reglas.PiezasValidas(jugadores[i].piezas, board).Count == 0)
                {
                    if (jugadores[i].piezas.Count == 0)
                    {
                        return jugadores[i];
                    }
                }
            }*/
            return score.minPuntuacion;
        }
    }
}
