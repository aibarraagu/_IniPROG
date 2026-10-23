int monedas = 23;
int jugadores = 4;

int monedasPorJugador = monedas / jugadores;
int monedasSobrantes = monedas % jugadores;

Console.WriteLine("Monedas disponibles: " + monedas);
Console.WriteLine("Jugadores: " + jugadores);
Console.WriteLine("Monedas por jugador: " + monedasPorJugador);
Console.WriteLine("Monedas sobrantes: " + monedasSobrantes);