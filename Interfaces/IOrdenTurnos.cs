using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOrdenTurnos<T>
    {
        public int jugadorActual { get; set; }
        public bool ordenReverso { get; set; }
        public IPlayer<T> ProximoTurno(List<IPlayer<T>> jugadores);
    }
}
