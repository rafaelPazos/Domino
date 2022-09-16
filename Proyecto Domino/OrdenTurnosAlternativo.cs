using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class OrdenTurnosAlternativo : IOrdenTurnos<int>
    {
        public int jugadorActual { get; set; }
        public bool ordenReverso { get; set; }
        public OrdenTurnosAlternativo()
        {
            ordenReverso = false;
        }

        public IPlayer<int> ProximoTurno(List<IPlayer<int>> jugadores)
        {
            if (ordenReverso)
            {
                return OrdenInverso(jugadores);
            }
            else return OrdenNormal(jugadores);
        }
        public IPlayer<int> OrdenNormal(List<IPlayer<int>> jugadores)
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
        public IPlayer<int> OrdenInverso(List<IPlayer<int>> jugadores)
        {
            if (jugadorActual == 0)
            {
                jugadorActual = jugadores.Count -1;
                return jugadores[jugadorActual];
            }
            else
            {
                jugadorActual--;
                return jugadores[jugadorActual];
            }
        }

    }
}
