using Proyecto_Domino;
using Interfaces;

namespace InterfazGrafica

{
    
    public partial class Form1 : Form
    {
        CantidadFichas cant = new CantidadFichas();
        IRepartirFichas<int> repartir;
        List<IPlayer<int>> jugadores = new List<IPlayer<int>>();
        IPlayer<int> jugadorActual;
        OrdenSalida primero = new OrdenSalida();
        IBoard<int> mesa;
        IRegla<int> regla;
        IOrdenTurnos<int> turnos;
        ICondicionFinalizacion<int> over;
        IScore<int> score = new Puntuacion();
        List<string> nombres = new List<string>{"Einstein","Rick","Morty","Newton"};
        IQuienGano<int> ganador;
        int indice = 0;
        bool encendido = false;
        int sinJugar = 0;
        public Form1()
        {
            InitializeComponent();
            numFichas.Items.Add(7);
            numFichas.Items.Add(8);
            numFichas.Items.Add(9);
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 7;
            if (int.TryParse(numFichas.Text, out a))
            {
                cant.CreacionFichas(int.Parse(numFichas.Text));
            }
            else cant.CreacionFichas(7);

            crearFicha.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RepartirFichas_Click(object sender, EventArgs e)
        {
            repartir = new RepartirFichas();
            repartir.Repartir(cant.numFichas, jugadores, 7);
            RepartirFichas.Enabled = false;
            sinDobles.Enabled = false;
        }

        private void Empezar_Click(object sender, EventArgs e)
        {
            bool gameover = false;
            jugadorActual = primero.Salida(jugadores);
            turnos.jugadorActual = jugadores.IndexOf(jugadorActual);
            IFicha<int> last;
            last = jugadorActual.Jugada(jugadorActual.piezas, regla,mesa);
            if (last.values[0] != -2)
            {
                mesa.Actualizar(last);
                jugadorActual.piezas.Remove(last);
                //Board.Text = mesa.ToString();
                progress.Items.Add(last.ToString());
                progress.Items.Add(" ");
            }
            gameover = over.Finalizo(jugadores, regla,mesa);
            while (!gameover)
            {
                jugadorActual = turnos.ProximoTurno(jugadores);
                last = jugadorActual.Jugada(jugadorActual.piezas, regla,mesa);
                if (last.values[0] != -2)
                {
                    sinJugar = 0;
                    progress.Items.Add(last.ToString());
                    progress.Items.Add(" ");
                    mesa.Actualizar(last);
                    //ladojugado.Text += mesa.cabezaJugada[mesa.cabezaJugada.Count - 1].ToString() + " ";
                    ladojugado.Visible = true;
                    jugadorActual.piezas.Remove(last);
                }
                if(last.values[0] == -2)
                {
                    sinJugar++;
                    jugadorActual.mePase += 1;
                    if(encendido && sinJugar <= 1)
                    {
                        turnos.ordenReverso = !turnos.ordenReverso;
                    }
                    //turnos.GirarOrden();
                }
                gameover = over.Finalizo(jugadores, regla,mesa);
            }
            //if (over.nollevan != 4) winner.Text = ($"El ganador es {over.ganador}");
            score.PuntuacionMinima(jugadores);
            ladojugado.Text = ($"{ Movimientos()}");
            ladojugado.Visible = true;
            winner.Text = ($"El ganador es {ganador.Ganador(jugadores,regla,mesa,score)}");
            winner.Visible = true;
        }

        private void Board_Click(object sender, EventArgs e)
        {

        }

        private void random_Click(object sender, EventArgs e)
        {
            jugadores.Add(new JugadorRandom(AsignarNombres()));
            ChequearJugadores();
        }

        private void botagorda_Click(object sender, EventArgs e)
        {
            jugadores.Add(new JugadorBotaGorda(AsignarNombres()));
            ChequearJugadores();
        }

        private void alternado_Click(object sender, EventArgs e)
        {
            jugadores.Add(new JugadorAlternado(AsignarNombres()));
            ChequearJugadores();
        }
        private string AsignarNombres()
        {
            string nombre;
            nombre = nombres[indice];
            indice++;
            return nombre;
        }
        private void ChequearJugadores()
        {
            if (jugadores.Count == 4)
            {
                random.Enabled = false;
                botagorda.Enabled = false;
                alternado.Enabled = false;
            }
        }

        private void reglatradicional_Click(object sender, EventArgs e)
        {
            regla = new Reglas();
            mesa = new Tablero();
            reglatradicional.Enabled = false;
            reglaalternativa.Enabled = false;
        }

        private void reglaalternativa_Click(object sender, EventArgs e)
        {
            regla = new ReglaAlternativa();
            mesa = new TableroAlternativo();
            reglatradicional.Enabled = false;
            reglaalternativa.Enabled = false;
        }

        private void sinDobles_Click(object sender, EventArgs e)
        {
            repartir = new RepartirFichasAlternativa();
            repartir.Repartir(cant.numFichas, jugadores, 7);
            RepartirFichas.Enabled = false;
            sinDobles.Enabled = false;
        }

        private void turnostradicional_Click(object sender, EventArgs e)
        {
            turnos = new OrdenTurnos();
            turnostradicional.Enabled = false;
            turnosalternativo.Enabled = false;
        }

        private void turnosalternativo_Click(object sender, EventArgs e)
        {
            encendido = true;
            turnos = new OrdenTurnosAlternativo();
            turnostradicional.Enabled = false;
            turnosalternativo.Enabled = false;
        }

        private void finalizaciontradicional_Click(object sender, EventArgs e)
        {
            over = new CondicionFinalizacion();
            finalizaciontradicional.Enabled = false;
            finalizacionalternativa.Enabled = false;
        }

        private void finalizacionalternativa_Click(object sender, EventArgs e)
        {
            over = new CondicionFinalizacionAlternativa();
            finalizaciontradicional.Enabled = false;
            finalizacionalternativa.Enabled = false;
        }

        private void ganadortradicional_Click(object sender, EventArgs e)
        {
            ganador = new QuienGano();
            //mesa = new Tablero();
            ganadortradicional.Enabled = false;
            ganadoralternativo.Enabled = false;
        }

        private void ganadoralternativo_Click(object sender, EventArgs e)
        {
            ganador = new QuienGanoAlternativo();
            //mesa = new TableroAlternativo();
            ganadortradicional.Enabled = false;
            ganadoralternativo.Enabled = false;
        }

        private void puntuacióntradicional_Click(object sender, EventArgs e)
        {
            score = new Puntuacion();
            puntuacióntradicional.Enabled = false;
            puntuaciónalternativa.Enabled = false;
        }

        private void puntuaciónalternativa_Click(object sender, EventArgs e)
        {
            score = new PuntuacionAlternativa();
            puntuacióntradicional.Enabled = false;
            puntuaciónalternativa.Enabled = false;
        }
        private string Movimientos()
        {
            string mov = "";
            for (int i = 0; i < mesa.cabezaJugada.Count - 1; i++)
            {
                mov += mesa.cabezaJugada[i] + " ";
            }
            return mov;
        }
    }
}