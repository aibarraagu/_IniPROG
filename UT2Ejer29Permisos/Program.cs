bool autenticado = true;
string rol = "editor";
string accion = "editar";
bool propietario = false;

if (autenticado == false)
{
    Console.WriteLine("Acción denegada");
}
else if (rol == "admin")
{
    Console.WriteLine("Accion permitida");
}

switch (rol)
{
    case "usuario":
        if (accion == "leer")
        {
            Console.WriteLine("Acción permitida");
        }
        else if (accion == "editar" && propietario == true)
        {
            Console.WriteLine("Acción permitida");
        }
        else
        {
            Console.WriteLine("Acción denegada");
        }
        break;
    case "editor":
        if (accion == "leer" || accion == "editar")
        {
            Console.WriteLine("Acción permitida");
        }
        else if (accion == "eliminar" && propietario == true)
        {
            Console.WriteLine("Acción permitida");
        }
        else
        {
            Console.WriteLine("Acción denegada");
        }
        break;
}