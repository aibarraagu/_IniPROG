int edad = 22;
int intentosFallidos = 3;
bool usuarioActivo = true;
bool cuentaBloqueada = true;
bool esAdministrador = true;
bool dobleFactorCorrecto = true;

bool mayorDeEdad = edad >=18;
bool menos3IntentosF = intentosFallidos<3;
bool cuentaDisponible = usuarioActivo && cuentaBloqueada! ;
bool seguridadBasica  = cuentaDisponible && dobleFactorCorrecto ;
bool accesoNormal = mayorDeEdad && seguridadBasica && menos3IntentosF ;
bool tieneAccesoAlSistema = accesoNormal || esAdministrador ;

Console.WriteLine("1. Es mayor de edad: " + mayorDeEdad);
Console.WriteLine("2. Tiene menos de 3 intentos fallidos: " + menos3IntentosF);
Console.WriteLine("3. La cuenta está disponible: " + cuentaDisponible);
Console.WriteLine("4. Supera la seguridad básica: " + seguridadBasica);
Console.WriteLine("5. Tiene acceso normal: " + accesoNormal);
Console.WriteLine("6. Tiene acceso al sistema: " + tieneAccesoAlSistema);
