int operacion = -1;
        bool valido;

        do
        {
            Console.WriteLine("Ingrese operación a realizar:");
            Console.WriteLine("1. Suma || 2. Resta || 3. Multiplicación || 4. División || 0. Salir");
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
            else if (operacion == 0)
            {
                Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                Console.WriteLine("Operación no válida.");
            }

        } while (operacion != 0);

