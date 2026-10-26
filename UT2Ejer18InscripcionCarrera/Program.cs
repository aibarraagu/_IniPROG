int edad = 17;
bool tieneAutorizacion = true;
bool inscripcionPagada = true;
bool documentacionEntregada = true;
double marcaAnterior = 52.30;

bool esMayorDeEdad = edad >=18 ;
bool puedeParticiparPorEdad = esMayorDeEdad || tieneAutorizacion;
bool tieneTramites = inscripcionPagada && documentacionEntregada;
bool puedeParticipar = esMayorDeEdad && tieneTramites;
bool marcaInferior = marcaAnterior <55.0;
bool grupoAvanzado = puedeParticipar && marcaInferior;


Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);
Console.WriteLine("Puede participar por edad: " + puedeParticiparPorEdad);
Console.WriteLine("Tiene los trámites completados: " + tieneTramites);
Console.WriteLine("Puede participar: " + puedeParticipar);
Console.WriteLine("Tiene una marca inferior a 55 minutos: " + marcaInferior);
Console.WriteLine("Puede entrar en el grupo avanzado: " + grupoAvanzado);
