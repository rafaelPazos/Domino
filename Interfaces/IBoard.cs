using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IBoard<T>
    {
        public (T,T) valoresActuales { get; set; }
        public List<string> cabezaJugada { get; set; }
        public void Actualizar(IFicha<T> ficha);
    }
}
