using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPlayer<T>
    {
        public List<IFicha<T>> piezas { get; set; }
        public string nombre { get; set; }
        public int mePase { get; set; }
        public IFicha<T> Jugada(List<IFicha<T>> fichas, IRegla<T> reglas,IBoard<T> board);
    }
}
