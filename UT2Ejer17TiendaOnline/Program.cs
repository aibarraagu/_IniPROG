double totalCompra = 67.50;
bool esPremium = false;
bool tieneCupon = true;
int productos = 4;

bool compraSupera50 = totalCompra >=50.0;
bool clienteEsPremium = esPremium;
bool tieneCuponYHaCompradoMasDeTresP = tieneCupon && productos >=3;
bool obtieneEnvioGratuitoSiCompraMayor50OPremium = esPremium || totalCompra >=50.0;
bool promocionEspecial = esPremium || (tieneCupon && totalCompra >= 30.0); 
bool noPuedePE = !esPremium;

Console.WriteLine("1. ¿La compra supera los 50 €?: " + compraSupera50);
Console.WriteLine("2. ¿El cliente es Premium?: " + clienteEsPremium);
Console.WriteLine("3. ¿Tiene cupón y al menos 3 productos?: " + tieneCuponYHaCompradoMasDeTresP);
Console.WriteLine("4. ¿Obtiene envío gratuito?: " + obtieneEnvioGratuitoSiCompraMayor50OPremium);
Console.WriteLine("5. ¿Puede usar la promoción especial?: " + promocionEspecial);
Console.WriteLine("6. ¿No puede acceder a la promoción exclusiva?: " + noPuedePE);