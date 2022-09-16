using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class CondicionFinalizacionAlternativa : ICondicionFinalizacion<int>
    {
        public int nollevan { get; set; }
        public IPlayer<int> ganador { get; set; }
        public bool Finalizo(List<IPlayer<int>> jugadores, IRegla<int> reglas, IBoard<int> board)
        {
            nollevan = 0;
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (PasadoDoble(jugadores))
                {
                    return true;
                }
                if (reglas.PiezasValidas(jugadores[i].piezas, board).Count == 0)
                {
                    if (jugadores[i].piezas.Count == 0)
                    {
                        //ganador = jugadores[i];
                        return true;
                    }
                    nollevan++;
                }
            }
            if (nollevan == 4) return true;
            else return false;
        }
        public bool PasadoDoble(List<IPlayer<int>> jugadores)
        {
            for (int i = 0; i < jugadores.Count; i++)
            {
                if (jugadores[i].mePase >= 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
