Console.WriteLine("Ingrese una cadena de texto: ");
string? cadena1 = Console.ReadLine();

int longitud = cadena1.Length;

if (cadena1.Length > 0)
{
    Console.WriteLine($"La longitud de la cadena ingresada es: {longitud}")
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
