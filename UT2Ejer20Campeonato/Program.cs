string nombre = "Marius";
int partidasJugadas = 15;
int partidasGanadas = 7;
int puntosObtenidos = 18;
int numeroDePenalizaciones = 5;
bool inscripcionPagada = false;
bool cuentaActiva = true;
bool haSidoSancionado = true;

int partidasPerdidas = partidasJugadas - partidasGanadas;
double mediaPuntos = puntosObtenidos / partidasJugadas;
bool haGanadoAlMenos5Partidas = partidasGanadas >=5;
bool mediaPuntosMayorOIgualQue100 = mediaPuntos >=100;
bool tieneMenosDe3Penalizaciones = numeroDePenalizaciones <3;
bool puedeParticipar = inscripcionPagada && cuentaActiva && !haSidoSancionado;
bool cumpleRequisitosDeportivos =  haGanadoAlMenos5Partidas && mediaPuntosMayorOIgualQue100 && tieneMenosDe3Penalizaciones; 
bool puedeClasificarse = puedeParticipar && cumpleRequisitosDeportivos;

Console.WriteLine(" --- INFORME DEL JUGADOR --- ");
Console.WriteLine("  ");
Console.WriteLine(" Jugador: ... " + nombre);
Console.WriteLine(" Partidas: ... " + partidasJugadas);
Console.WriteLine(" Victorias: ... " + partidasGanadas);
Console.WriteLine(" Partidas no ganadas: ... " + partidasPerdidas);
Console.WriteLine(" Media de puntos: ... " + mediaPuntos);
Console.WriteLine(" Puede participar: ... " + puedeParticipar);
Console.WriteLine(" Cumple requisitos deportivos: ... " + cumpleRequisitosDeportivos);
Console.WriteLine(" Puede clasificarse: ... " + puedeClasificarse);