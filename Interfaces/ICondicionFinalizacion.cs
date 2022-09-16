using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICondicionFinalizacion<T>
    {
        public int nollevan { get; set; }
        //public IPlayer<T> ganador { get; set; }
        public bool Finalizo(List<IPlayer<T>> jugadores, IRegla<T> reglas, IBoard<T> board);
    }
}
