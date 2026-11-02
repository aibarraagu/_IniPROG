int edad = 20;
bool estudiante = true;
bool familiaNumerosa = true;

Console.WriteLine("--- ENTRADA ---");
if (edad < 6)
{
    Console.WriteLine("Precio final: Entrada gratuita");
}
else if (edad >= 65)
{
    Console.WriteLine("Precio final:6 €");
}
else if(edad>=6 && edad <= 17)
{
    Console.WriteLine("Precio final: 8 €");
}
else if (familiaNumerosa == true)
{
    Console.WriteLine("Precio final: 9 €");
}
else if (estudiante == true)
{
    Console.WriteLine("Precio final: 10 €");
} else
{
    Console.WriteLine("Precio final: 15€");
}