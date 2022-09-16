using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class OrdenSalida
    {
        public IPlayer<int> Salida(List<IPlayer<int>> jugadores)
        {
            Random random = new Random();
            return jugadores[random.Next(0, jugadores.Count - 1)];
        }
    }
}
