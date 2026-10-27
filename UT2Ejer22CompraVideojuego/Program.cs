double saldo = 45.00;
double precioVideojuego = 39.99;

if (saldo >= precioVideojuego)
{
    saldo -= precioVideojuego;
    Console.WriteLine("Compra realizada correctamente.");
} else
{
    Console.WriteLine("Saldo insuficiente.");
}