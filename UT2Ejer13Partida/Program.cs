int puntos = 100;
int vidas = 3;
int monedas = 10;

puntos += 50;
monedas += 5;
vidas -= 1;
puntos *=2;
monedas -=3;
vidas +=1;

Console.WriteLine("--- ESTADO DE LA PARTIDA ---");
Console.WriteLine(" ");
Console.WriteLine("Puntos: " + puntos);
Console.WriteLine("Vidas: " + vidas);
Console.WriteLine("Monedas: " + monedas);