using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class CantidadFichas
    {
        public List<IFicha<int>> numFichas { get; set; }
        public void CreacionFichas(int tokens)
        {
            numFichas = new List<IFicha<int>>();  
            for (int i = 0; i <= tokens; i++)
            {
                for (int j = i; j <= tokens; j++)
                {
                    List<int> list = new List<int>();
                    list.Add(i);
                    list.Add(j);
                    numFichas.Add(new Ficha(list));
                }
            }
        }


    }
}
