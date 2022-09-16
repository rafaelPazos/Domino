using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class Puntuacion : IScore<int>
    {
        public IPlayer<int> minPuntuacion { get; set; }
        public void PuntuacionMinima(List<IPlayer<int>> jugadores)
        {
            minPuntuacion = new JugadorRandom("");
            int min = int.MaxValue;
            int puntP = 0;
            for (int i = 0; i < jugadores.Count; i++)
            {
                puntP = PuntuacionJugador(jugadores[i]);
                if (min > puntP)
                {
                    min = puntP;
                    minPuntuacion = jugadores[i];
                    minPuntuacion.nombre = jugadores[i].nombre;
                }
            }
        }
        public int PuntuacionJugador(IPlayer<int> jugador)
        {
            int punt = 0;
            for (int i = 0; i < jugador.piezas.Count; i++)
            {
                punt += jugador.piezas[i].Value();
            }
            return punt;
        }

    }
}
