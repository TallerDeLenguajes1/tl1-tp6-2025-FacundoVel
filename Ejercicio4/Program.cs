Console.WriteLine("Ingrese una cadena de texto: ");
string? cadena1 = Console.ReadLine();

int? longitud = cadena1.Length;

if (longitud > 0)
{
    Console.WriteLine($"La longitud de la cadena ingresada es: {longitud}");
}
else
{
    Console.WriteLine("La cadena ingresada está vacía.");
}

Console.WriteLine("Ingrese otra cadena de texto: ");
string? cadena2 = Console.ReadLine();
string concatenado = cadena1 + " " + cadena2;
Console.WriteLine($"Resultado de la concatenacion: {concatenado}");

Console.WriteLine("Ingrese una nueva cadena: ");
string? cadena3 = Console.ReadLine();

 Console.Write("Ingrese una posición inicial para extraer la subcadena: ");
        string? inputInicio = Console.ReadLine();
        Console.Write("Ingrese la cantidad de caracteres a extraer: ");
        string? inputLargo = Console.ReadLine();

        if (int.TryParse(inputInicio, out int inicio) && int.TryParse(inputLargo, out int largo))
        {
            if (inicio >= 0 && largo > 0 && (inicio + largo) <= cadena3.Length)
            {
                string subcadena = cadena3.Substring(inicio, largo);
                Console.WriteLine($"Subcadena extraída: {subcadena}");
            }
            else
            {
                Console.WriteLine("Parámetros fuera de rango.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida para la subcadena.");
        }   

Console.WriteLine("Ingrese una cadena para recorrer caracter por caracter: ");
string? cadena4 = Console.ReadLine();
foreach (char c in cadena4)
{
    Console.WriteLine(c);
}

Console.WriteLine("Ingrese una nueva cadena: ");
string? cadena5 = Console.ReadLine();
Console.WriteLine("Ingrese una palabra para buscar en la cadena: ");
string? buscada = Console.ReadLine();
int? longitud2 = cadena5.Length;

if(longitud2 > 0)
{
     if (cadena5.Contains(buscada))
    {
        Console.WriteLine($"La palabra '{buscada}' se encuentra en la cadena.");
    }
    else
    {
        Console.WriteLine($"La palabra '{buscada}' NO se encuentra en la cadena.");
    }
    string mayusculas = cadena5.ToUpper();
    Console.WriteLine($"La cadena pasada a mayusculas es: {mayusculas}");
    string minusculas = cadena5.ToLower();
    Console.WriteLine($"La cadena pasada a minusculas es: {minusculas}");
}
else
{
    Console.WriteLine("La cadena ingresada está vacía.");
}

Console.Write("\nIngrese una cadena separada por algún caracter (ej: coma, guión, etc.): ");
string? cadenaSeparada = Console.ReadLine();
Console.Write("Ingrese el caracter separador (ej: , o -): ");
string? separador = Console.ReadLine();

longitudCadenaSeparada = cadenaSeparada.Length;
longitudSeparador = separador.Length;

if (longitudCadenaSeparada > 0 && longitudSeparador > 0)
{
    string[] partes = cadenaSeparada.Split(separador);
    Console.WriteLine("Partes separadas:");
    foreach (string parte in partes)
    {
        Console.WriteLine(parte.Trim());
    }
}