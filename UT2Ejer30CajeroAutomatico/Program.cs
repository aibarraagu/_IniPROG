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
}
else if (intentosFallidos >= 3)
{
    Console.WriteLine("Demasiados intentos. Tarjeta bloqueada.");
}
else if (pinIntroducido! == pinCorrecto)
{
    Console.WriteLine("Pin incorrecto.");
}

switch (operacion)
    case 1:
    break;