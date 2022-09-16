using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRepartirFichas<T>
    {
        public void Repartir(List<IFicha<T>> fichas, List<IPlayer<T>> jugadores, int cant);
    }
}
