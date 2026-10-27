double nota = 7.5;
int asistencia = 85;
bool proyectoEntregado = true;

if ( proyectoEntregado == false)
{
    Console.WriteLine("Proyecto pendiente");
} 
else if (asistencia < 80)
{
    Console.WriteLine("No cumple la asistencia mínima");
} 
else if (nota < 5)
{
    Console.WriteLine("Suspenso");
}
else if (nota >=5 && nota < 7)
{
    Console.WriteLine("Aprobado");
} 
else if (nota >=7 && nota < 9)
{
    Console.WriteLine("Notable");
}
else if (nota >=9 && nota < 10)
{
    Console.WriteLine("Sobresaliente");
}

// Tiene que ir de menor a mayor porque si no podría saltarse alguna cosa que hiciese al programa parar pero como está mal el orden no para y muestra lo primero que ve que es true