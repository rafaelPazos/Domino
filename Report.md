## Proyecto Domino ##

.

El proyecto Domino está creado de manera tal, que, al ejecutarlo, el usuario pueda implementar una modalidad de Domino a su gusto, a través de la interfaz gráfica.

La solución está compuesta por tres proyectos en c# 10, NET Core 6:

Interfaces
Interfaz Gráfica
Proyecto Domino

Comenzaremos hablando de las Interfaces

    public interface IBoard<T>
    {
        public (T,T) valoresActuales { get; set; }
        public List<string> cabezaJugada { get; set; }
        public void Actualizar(IFicha<T> ficha);
    }
    La propiedad valoresActuales concibe los dos valores actuales del tablero
    La lista cabezaJugada almacenará por cual lugar se jugaron todas las fichas.
    El método Actualizar recibirá una interfaz IFicha<T> el cual se encargará de refrescar las cabezas disponibles para jugar en la mesa.


    public interface ICondicionFinalizacion<T>
    {
        public int nollevan { get; set; }
        public bool Finalizo(List<IPlayer<T>> jugadores, IRegla<T> reglas, IBoard<T> board);
    }
   Le damos el uso a la variable de tipo int nollevan para saber cuántos jugadores no poseen Fichas Válidas.
   El método bool Finalizó analiza si bajo una determinada condición preestablecida el juego cumple si se ha terminado o no.


    public interface IFicha<T>
    {
        public List<T> values { get; set; }
        public int Value();
    }
    La propiedad values se encarga de manejar todos los valores de una determinada ficha, es decir la cantidad de cabezas y sus respectivos valores.
    El método Value da como resultado el valor total de la ficha.


    public interface IOrdenTurnos<T>
    {
        public int jugadorActual { get; set; }
        public bool ordenReverso { get; set; }
        public IPlayer<T> ProximoTurno(List<IPlayer<T>> jugadores);
    }
    La propiedad jugadorActual brinda como información el jugador en turno.
    La propiedad booleana ordenReverso muestra si el orden de turnos es de izquierda a derecha o viceversa.
    El método ProximoTurno devuelve al jugador encargado de hacer su jugada.


    public interface IPlayer<T>
    {
        public List<IFicha<T>> piezas { get; set; }
        public string nombre { get; set; }
        public int mePase { get; set; }
        public IFicha<T> Jugada(List<IFicha<T>> fichas, IRegla<T> reglas,IBoard<T> board);
    }
    La lista de tipo IFicha recoge las piezas que posee cada jugador en el juego.
    La propiedad de tipo string es encargada de mostrar y decidir el nombre de cada jugador.
    Esta propiedad de tipo int (mePase) almacena la cantidad de veces que un jugador no ha podido devolver una jugada válida.
    El método Jugada devuelve una IFicha para continuar el desarrollo del juego.


    public interface IQuienGano<T>
    {
        public IPlayer<T> Ganador(List<IPlayer<T>> jugadores, IRegla<T> reglas, IBoard<T> board, IScore<T> score);
    }
    Devuelve el IPlayer ganador de la partida.



    public interface IRegla<T>
    {
        public List<IFicha<T>> PiezasValidas(List<IFicha<T>> piezas,IBoard<T> board);
        public bool JugadaValida(IFicha<T> pieza, IBoard<T> board);
    }
    El primer método es el encargado, bajo un criterio en específico, validar todas las fichas de jugador a analizar teniendo en cuenta los valores del tablero.
    Tiene el mismo concepto,lo que analizando las jugadas de forma individual.



    public interface IRepartirFichas<T>
    {
        public void Repartir(List<IFicha<T>> fichas, List<IPlayer<T>> jugadores, int cant);
    }
    Está encargado,bajo un criterio en específico, repartir una cantidad fijada de fichas a cada jugador.



    public interface IScore<T>
    {
        public IPlayer<T> minPuntuacion { get; set; }
        public void PuntuacionMinima(List<IPlayer<T>> jugadores);
        public int PuntuacionJugador(IPlayer<T> player);
    }
    La primera propiedad tiene como objetivo guardar, bajo criterios particulares, el jugador con menor puntación.
    El metódo PuntuaciónMinima se encarga de calcular para luego almacenar en la propiedad local minPuntuación el jugador con la menor puntuación.
    El método PuntuaciónJugador se enfoca, bajo criterios introducidos por el programador, de calcular la puntuación individual de cada participante en el videojuego.



    Luego de introducidas las interfaces, se propusieron 2 implementaciones de cada una exceptuando IFicha e IPlayer(esta tiene 3 implementaciones orientadas)
    En el caso de las implementaciones de IRegla e IBoard se correlacionan,ya que por un lado se establece el criterio por el cual una IFicha es válida en la mesa y
    además la forma de actualizar los valoresActuales del tablero. En una de las implementaciones se tiene en cuenta la manera tradicional de como vincular dos fichas
    en el domino y en la otra, contempla la manera tradicional y a su vez, si ambas cabezas a coincidir son múltiplos de 2.

    Abordando las implementaciones de ICondicionFinalizacion por un lado evidencia si algún jugador se quedó sin fichas o ninguno de ellos tiene para seguir jugando, o como segunda variante ambas condiciones anteriores también y si algún jugador se paso dos veces durante la partida.

    Las implementaciones de IOrdenTurnos corresponden por llamarlo a que el juego siga en orientación derecha, o si algún jugador se pasa, cambiar el sentido del próximo a jugar(si le seguía a la derecha cambiar hacia izquierda y viceversa)

    Las implementaciones de jugadores coorresponden a lo ampliamente conocido como estrategia del bota gorda, un jugador que juega una ficha random en su poder o un jugador que alterne entre estas dos estrategias simples.

    Respectivo a IQuienGano una de las implementaciones devuelve la forma decidida por el usuario de calcular la puntuación mínima y la otra devuelve como ganador el
    jugador que mas veces no jugó en la partida.

    A continuación explicaremos la diferencia entre las implementaciones de IRepartirFichas

            Random random = new Random();
            bool[] mask = new bool[fichas.Count - 1];
            int index;
            foreach (var jugador in jugadores)
            {
                while(jugador.piezas.Count != cant)
                {
                    index = random.Next(0, fichas.Count - 1);
                    if (fichas[index].values[0] != fichas[index].values[1] && !mask[index])
                    {
                        jugador.piezas.Add(fichas[index]);
                        mask[index] = true;

                    }
                }
            }
            Lo que observamos en el código anterior es través de par de ciclos a cada jugador nos aseguramos de otorgarle la cantidad de fichas decididas sin ningún tipo de repetición y, en este caso en específico no se tiene en cuenta los dobles.
            Por otro lado, en un proceso muy parecido se contemplan todas las fichas.



    Con respecto a la IScore, por un lado se calcula la puntuación mínima del juego clásico del dominó y por otra vía, teniendo en cuenta las veces que cada jugador no jugó, al valor de cada ficha en su poder se le multipló la cantidad de veces que se pasó y se halló la suma total de esta operación.              
### Fin. ###

