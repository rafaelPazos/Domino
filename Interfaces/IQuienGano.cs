using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IQuienGano<T>
    {
        public IPlayer<T> Ganador(List<IPlayer<T>> jugadores, IRegla<T> reglas, IBoard<T> board, IScore<T> score);
    }
}
