double precioCamiseta = 19.95;
int cantidadCamisetas = 2;
double precioPantalon = 35.50;
int cantidadPantalones = 1;

double costeTotalCamisetas = precioCamiseta*cantidadCamisetas;
double costeTotalPantalones = precioPantalon*cantidadPantalones;
double precioTotalCompra = costeTotalCamisetas+costeTotalPantalones;

Console.WriteLine("--- TICKET ---");
Console.WriteLine(" ");
Console.WriteLine("Camisetas: " + costeTotalCamisetas);
Console.WriteLine("Pantalones: " + costeTotalPantalones);
Console.WriteLine("TOTAL: " + precioTotalCompra);
