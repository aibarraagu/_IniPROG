int edad = 14;
double altura = 1.55;
bool tieneEntrada = true;
bool vaAcompanado = false;

bool mayorDeDoce = edad >= 12;
bool personaMideAlMenosMetroCincuenta = altura >=1.50; 
bool tieneEdadSuficienteYAlturaSuficiente = mayorDeDoce && personaMideAlMenosMetroCincuenta;
bool TieneEntradaYCumpleLosRequisitosDeEdadYAltura = tieneEntrada && tieneEdadSuficienteYAlturaSuficiente;
bool puedeAccederSiCumpleTodosLosRequisitosAnterioresOVaAcompañada = TieneEntradaYCumpleLosRequisitosDeEdadYAltura || vaAcompanado;

Console.WriteLine("La persona tiene 12 años o más: " + mayorDeDoce);
Console.WriteLine("La persona mide al menos 1.50 metros: " + personaMideAlMenosMetroCincuenta);
Console.WriteLine("Tiene edad suficiente Y altura suficiente: " + tieneEdadSuficienteYAlturaSuficiente);
Console.WriteLine("Tiene entrada Y cumple los requisitos de edad y altura: " + TieneEntradaYCumpleLosRequisitosDeEdadYAltura);
Console.WriteLine("Puede acceder si cumple todos los requisitos anteriores O va acompañada: " + puedeAccederSiCumpleTodosLosRequisitosAnterioresOVaAcompañada);


