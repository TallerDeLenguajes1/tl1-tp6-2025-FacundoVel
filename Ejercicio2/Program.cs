int operacion = -1;
        bool valido;

        do
        {
            Console.WriteLine("Ingrese operación a realizar:");
            Console.WriteLine("5. Valor Absoluto|| 6. Cuadrado || 7. Raiz Cuadrada || 8. Seno || 9. Coseno || 10.Parte Entera || 0. Salir");
            string? opcion = Console.ReadLine();
            valido = int.TryParse(opcion, out operacion);

            if (!valido)
            {
                Console.WriteLine("Ingrese un número válido.");
                continue;
            }

            if (operacion == 5)
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
                    Console.WriteLine($"El resultado del cuadrado es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            else if (operacion == 7)
            {
                Console.WriteLine("Raiz Cuadrada");
                Console.Write("Ingrese un número: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int num))
                if (numero >= 0)
            {
                double raiz = numero;
                double tolerancia = 0.000001;
                while ((raiz * raiz - numero) > tolerancia || (raiz * raiz - numero) < -tolerancia)
                {
                    raiz = (raiz + numero / raiz) / 2.0;
                }
                Console.WriteLine($"Raíz cuadrada: {raiz}");
            }
            else
            {
                Console.WriteLine("Raíz cuadrada: No definida para números negativos.");
            }
            else if (operacion == 8)
            {
                Console.WriteLine("Seno");
                Console.Write("Ingrese un ángulo en grados: ");
                string? input = Console.ReadLine();

                double x = numero; 
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
            Console.WriteLine($"Seno (aproximado): {seno}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            else if (operacion == 9)
            {
                Console.WriteLine("Coseno");
                Console.Write("Ingrese un ángulo en grados: ");
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
                    Console.WriteLine($"Coseno (aproximado): {coseno}");
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

