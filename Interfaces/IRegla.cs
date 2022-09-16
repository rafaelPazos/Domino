using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRegla<T>
    {
        public List<IFicha<T>> PiezasValidas(List<IFicha<T>> piezas,IBoard<T> board);
        public bool JugadaValida(IFicha<T> pieza, IBoard<T> board);
    }
}
