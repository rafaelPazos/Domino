using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class JugadorAlternado : IPlayer<int>
    {
        public List<IFicha<int>> piezas { get; set; }
        public string nombre { get; set; }
        public int mePase { get; set; }
        public JugadorAlternado(string nombre)
        {
            this.nombre = nombre;
            piezas = new List<IFicha<int>>();
        }
        public IFicha<int> Jugada(List<IFicha<int>> piezas, IRegla<int> reglas, IBoard<int> board)
        {
            Random random = new Random();
            int num = 0;
            num = random.Next(1,2);
            if(num == 1) return JugadaRandom(piezas, reglas, board);
            return JugadaGorda(piezas, reglas, board);
        }
        public IFicha<int> JugadaGorda(List<IFicha<int>> piezas, IRegla<int> reglas, IBoard<int> board)
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
        public IFicha<int> JugadaRandom(List<IFicha<int>> piezas, IRegla<int> reglas, IBoard<int> board)
        {
            List<IFicha<int>> fichasValidas = new List<IFicha<int>>();
            fichasValidas = reglas.PiezasValidas(piezas, board);
            Random random = new Random();
            List<int> pasa = new List<int>(); pasa.Add(-2); pasa.Add(-2);
            if (fichasValidas.Count == 0) return new Ficha(pasa);
            return fichasValidas[random.Next(0, fichasValidas.Count - 1)];
        }
        public override string ToString()
        {
            return $"{nombre}";
        }
    }
}
