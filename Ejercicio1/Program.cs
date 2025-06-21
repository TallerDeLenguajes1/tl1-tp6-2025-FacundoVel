Console.WriteLine("Ingrese un numero: ");
string numero = Console.ReadLine();
bool esNumero = int.TryParse(numero, out int resultado);

if(esNumero)
{
    if(resultado > 0)
    {
        int invertido = 0;
        while (resultado > 0)
        {
            invertido = invertido * 10 + resultado % 10;
            resultado /= 10;
        }
        Console.WriteLine("El numero invertido es: " + invertido);
    }
}
else
{
    Console.WriteLine("El numero ingresado no es positivo o no es un numero valido.");
}


