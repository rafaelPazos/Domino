using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Proyecto_Domino
{
    public class JugadorRandom : IPlayer<int>
    {
        public List<IFicha<int>> piezas { get; set; }
        public string nombre { get; set; }
        public int mePase { get; set; }
        public JugadorRandom(string nombre)
        {
            this.nombre = nombre;
            piezas = new List<IFicha<int>>();
        }
        public IFicha<int> Jugada(List<IFicha<int>> piezas, IRegla<int> reglas, IBoard<int> board)
        {
            List<IFicha<int>> fichasValidas = new List<IFicha<int>>();
            fichasValidas = reglas.PiezasValidas(piezas,board);
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
