using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IScore<T>
    {
        public IPlayer<T> minPuntuacion { get; set; }
        public void PuntuacionMinima(List<IPlayer<T>> jugadores);
        public int PuntuacionJugador(IPlayer<T> player);
    }
}
