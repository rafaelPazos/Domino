using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFicha<T>
    {
        public List<T> values { get; set; }
        public int Value();
    }
}
