using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class RepartirFichasAlternativa : IRepartirFichas<int>
    {
        public void Repartir(List<IFicha<int>> fichas, List<IPlayer<int>> jugadores, int cant)
        {
            Random random = new Random();
            bool[] mask = new bool[fichas.Count - 1];
            int index;
            foreach (var jugador in jugadores)
            {
                while(jugador.piezas.Count != cant)
                {
                    index = random.Next(0, fichas.Count - 1);
                    if (fichas[index].values[0] != fichas[index].values[1] && !mask[index])
                    {
                        jugador.piezas.Add(fichas[index]);
                        mask[index] = true;

                    }
                }
                /*for (int i = 0; i < cant; i++)
                {
                    masc = random.Next(0, fichas.Count - 1);
                    if(fichas[masc].values[0] != fichas[masc].values[1])
                    {
                        jugador.piezas.Add(fichas[masc]);
                        fichas.RemoveAt(masc);
                    }
                }*/
            }
        }
    }
}
