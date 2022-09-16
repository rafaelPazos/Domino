using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class JugadorBotaGorda : IPlayer<int>
    {
        public List<IFicha<int>> piezas { get; set; }
        public string nombre { get; set; }
        public int mePase { get; set; }
        public JugadorBotaGorda(string nombre)
        {
            this.nombre = nombre;
            piezas = new List<IFicha<int>>();
        }
        public IFicha<int> Jugada(List<IFicha<int>> piezas, IRegla<int> reglas, IBoard<int> board)
        {
            List<IFicha<int>> fichasValidas = new List<IFicha<int>>();
            fichasValidas = reglas.PiezasValidas(piezas, board);
            List<int> pasa = new List<int>(); pasa.Add(-2); pasa.Add(-2);
            if (fichasValidas.Count == 0) return new Ficha(pasa);
            return FichaGorda(fichasValidas);

        }
        public IFicha<int> FichaGorda(List<IFicha<int>> piezas)
        {
            int maxvalue = -1;
            int tempValue = 0;
            IFicha<int> ficha = piezas[0];
            for (int i = 1; i < piezas.Count; i++)
            {
                tempValue = piezas[i].Value();
                if (maxvalue < tempValue)
                {
                    maxvalue = tempValue;
                    ficha = piezas[i];
                }
            }
            return ficha;
        }
        public override string ToString()
        {
            return $"{nombre}";
        }
    }
}
