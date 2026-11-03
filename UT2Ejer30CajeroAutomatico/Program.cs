bool tarjetaActiva = true;
int pinCorrecto = 1234;
int pinIntroducido = 1234;
int intentosFallidos = 1;
double saldo = 850.00;
double cantidad = 200.00;
int operacion = 2;

if (tarjetaActiva == false)
{
    Console.WriteLine("Tarjeta bloqueada");
    return;
}
else if (intentosFallidos >= 3)
{
    Console.WriteLine("Demasiados intentos. Tarjeta bloqueada.");
    return;
}
else if (pinIntroducido != pinCorrecto)
{
    Console.WriteLine("Pin incorrecto.");
    return;
}

if (operacion == 1)
{
    Console.WriteLine("Tu saldo es: " + saldo);
}
else if (operacion == 2)
{
    if (cantidad > 0 && cantidad <= saldo)
    {
        Console.WriteLine("Tu saldo previo era: " + saldo);
        saldo -= cantidad;
        Console.WriteLine("Se ha restado: " + cantidad);
        Console.WriteLine("Y tu saldo es: " + saldo);
    }
    else
    {
        Console.WriteLine("Error");
        return;
    }
}
else if (operacion == 3)
{
    if (cantidad > 0)
    {
        saldo += cantidad;
        Console.WriteLine("Ha ingresado: " + cantidad);
        Console.WriteLine("Y tu saldo es: " + saldo);
    }
    else
    {
        Console.WriteLine("Error");
        return;
    }
}
else if (operacion == 4)
{
    Console.WriteLine("Gracias por utilizar el cajero.");

}
else
{
    Console.WriteLine("Operación no válida");
}