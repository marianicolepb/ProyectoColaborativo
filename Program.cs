using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("Seleccione una operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Módulo");
        while (true)
        {
            Console.Write("Ingrese la opción (1/2/3/4): ");
            string opcion = Console.ReadLine();

            if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4")
            {
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Resultado: " + Sumar(num1, num2));
                        break;
                    case "2":
                        Console.WriteLine("Resultado: " + Restar(num1, num2));
                        break;
                    case "3":
                        Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                        break;
                    case "4":
                        Console.WriteLine("Resultado: " + Dividir(num1, num2));
                        break;
                    case "5":
                        Console.WriteLine("Resultado: " + Modulo(num1, num2)); // Llamada al nuevo método
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }

            Console.Write("¿Desea realizar otra operación? (s/n): ");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() != "s")
            {
                break;
            }
        }
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static double Dividir(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: División por cero");
            return double.NaN; // Retorna NaN para indicar un error
        }
        return a / b;
    }

    static double Modulo(double a, double b) // Nueva función para el módulo
    {
        if (b == 0)
        {
            Console.WriteLine("Error: División por cero");
            return double.NaN; // Retorna NaN para indicar un error
        }
        return a % b;
    }
}
