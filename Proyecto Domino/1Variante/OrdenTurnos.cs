using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class OrdenTurnos : IOrdenTurnos<int>
    {
        public int jugadorActual { get; set; }
        public bool ordenReverso { get; set; }
        public OrdenTurnos()
        {
            ordenReverso = false;
        }
        public IPlayer<int> ProximoTurno(List<IPlayer<int>> jugadores)
        {
            if (jugadorActual + 1 == jugadores.Count)
            {
                jugadorActual = 0;
                return jugadores[jugadorActual];
            }
            else
            {
                jugadorActual++;
                return jugadores[jugadorActual];
            }
        }
    }
}
