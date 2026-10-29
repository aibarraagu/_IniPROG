double numero1 = 20;
double numero2 = 5;
char operacion = '*';
switch (operacion)
{
    case '+':
        Console.WriteLine(numero1 + numero2);
        break;
    case '-':
        Console.WriteLine(numero1 - numero2);
        break;
    case '*':
        Console.WriteLine(numero1 * numero2);
        break;
    case '/':
        
        if (numero1 / numero2 == 0)
        {
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine(numero1 / numero2);
        }
        break;
    default:
        Console.WriteLine("Operación no válida");
        break;
}
