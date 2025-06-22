int operacion = -1;
bool valido;

do
{
    Console.WriteLine("Ingrese operación a realizar:");
    Console.WriteLine("1. Suma || 2. Resta || 3. Multiplicación || 4. División");
    Console.WriteLine("5. Valor Absoluto || 6. Cuadrado || 7. Raíz Cuadrada || 8. Seno || 9. Coseno || 10. Parte Entera || 0. Salir");

    string? opcion = Console.ReadLine();
    valido = int.TryParse(opcion, out operacion);

    if (!valido)
    {
        Console.WriteLine("Ingrese un número válido.");
        continue;
    }

    if (operacion == 1)
    {
        Console.WriteLine("Suma");
        Console.Write("Ingrese el primer número: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo número: ");
        string? input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 2)
    {
        Console.WriteLine("Resta");
        Console.Write("Ingrese el primer número: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo número: ");
        string? input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int resultado = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 3)
    {
        Console.WriteLine("Multiplicación");
        Console.Write("Ingrese el primer número: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo número: ");
        string? input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            int resultado = num1 * num2;
            Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 4)
    {
        Console.WriteLine("División");
        Console.Write("Ingrese el primer número: ");
        string? input1 = Console.ReadLine();
        Console.Write("Ingrese el segundo número: ");
        string? input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            if (num2 != 0)
            {
                int resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 5)
    {
        Console.WriteLine("Valor Absoluto");
        Console.Write("Ingrese un número: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int num))
        {
            int resultado = (num < 0) ? -num : num;
            Console.WriteLine($"El valor absoluto es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 6)
    {
        Console.WriteLine("Cuadrado");
        Console.Write("Ingrese un número: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int num))
        {
            int resultado = num * num;
            Console.WriteLine($"El cuadrado es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 7)
    {
        Console.WriteLine("Raíz Cuadrada");
        Console.Write("Ingrese un número: ");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out double numero))
        {
            if (numero >= 0)
            {
                double raiz = numero;
                double tolerancia = 0.000001;
                while ((raiz * raiz - numero) > tolerancia || (raiz * raiz - numero) < -tolerancia)
                {
                    raiz = (raiz + numero / raiz) / 2.0;
                }
                Console.WriteLine($"Raíz cuadrada aproximada: {raiz}");
            }
            else
            {
                Console.WriteLine("No se puede calcular la raíz de un número negativo.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 8)
    {
        Console.WriteLine("Seno (en radianes)");
        Console.Write("Ingrese un número (en radianes): ");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out double x))
        {
            double seno = 0;
            int signo = 1;
            for (int i = 0; i < 10; i++)
            {
                double termino = 1;
                int exponente = 2 * i + 1;
                for (int j = 1; j <= exponente; j++)
                    termino *= x / j;
                seno += signo * termino;
                signo *= -1;
            }
            Console.WriteLine($"Seno aproximado: {seno}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 9)
    {
        Console.WriteLine("Coseno (en radianes)");
        Console.Write("Ingrese un número (en radianes): ");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out double x))
        {
            double coseno = 0;
            int signo = 1;
            for (int i = 0; i < 10; i++)
            {
                double termino = 1;
                int exponente = 2 * i;
                for (int j = 1; j <= exponente; j++)
                    termino *= x / j;
                coseno += signo * termino;
                signo *= -1;
            }
            Console.WriteLine($"Coseno aproximado: {coseno}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 10)
    {
        Console.WriteLine("Parte Entera");
        Console.Write("Ingrese un número: ");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out double numero))
        {
            int parteEntera = (int)numero;
            Console.WriteLine($"La parte entera es: {parteEntera}");
        }
        else
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
    else if (operacion == 0)
    {
        Console.WriteLine("Saliendo del programa...");
    }
    else
    {
        Console.WriteLine("Operación no válida.");
    }

} while (operacion != 0);
