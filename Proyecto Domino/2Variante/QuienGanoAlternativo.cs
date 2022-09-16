using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class QuienGanoAlternativo : IQuienGano<int>
    {
        public IPlayer<int> Ganador(List<IPlayer<int>> jugadores, IRegla<int> reglas, IBoard<int> board, IScore<int> score)
        {
            return MayorPases(jugadores);
        }
        public IPlayer<int> MayorPases(List<IPlayer<int>> jugadores)
        {
            int pasesMayor = int.MinValue;
            IPlayer<int> player = new JugadorAlternado("pepe");
            for (int i = 0; i < jugadores.Count; i++)
            {
                if(pasesMayor < jugadores[i].mePase)
                {

                    pasesMayor = jugadores[i].mePase;
                    player = jugadores[i];
                    player.nombre = jugadores[i].nombre;
                }
            }
            return player;
        }
    }
}
