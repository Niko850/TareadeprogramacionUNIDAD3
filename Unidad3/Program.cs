using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> nombres = new List<string>();
        List<int> edades = new List<int>();

        // Uso de FUNCIÓN 1 para obtener la cantidad de personas
        int cantidad = LeerNumeroValidado("¿Cuántas personas registrará?: ", 1);

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"--- Registro Persona {i + 1} ---");

            Console.Write("Nombre: ");
            nombres.Add(Console.ReadLine());

            // Uso de FUNCIÓN 2 para obtener la edad validada
            int edad = LeerNumeroValidado("Edad: ", 0);
            edades.Add(edad);
        }

        // Uso de PROCEDIMIENTO para mostrar los resultados
        MostrarReporte(nombres, edades);

        Console.WriteLine("===============================");
        Console.WriteLine("Presiona cualquier tecla para cerrar.");
        Console.ReadKey();
    }

    // --- FUNCIÓN 1 y 2 (Reutilizable) ---
    // Tipo de retorno: int
    // Parámetros: string mensaje, int min (valor mínimo aceptado)
    static int LeerNumeroValidado(string mensaje, int min)
    {
        int valor = 0;
        bool esValido = false;

        while (!esValido)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine();
            bool sePudoConvertir = int.TryParse(entrada, out valor);

            if (sePudoConvertir && valor >= min)
            {
                esValido = true;
            }
            else
            {
                Console.WriteLine($"Error: Ingrese un número válido (mínimo {min}).");
            }
        }
        return valor; // Retorna el número ya validado
    }

    // --- PROCEDIMIENTO ---
    // Tipo de retorno: void (Sin retorno)
    // Parámetros: List<string> listaNombres, List<int> listaEdades
    static void MostrarReporte(List<string> listaNombres, List<int> listaEdades)
    {
        Console.WriteLine("===============================");

        if (listaNombres.Count == 1)
        {
            string estado = (listaEdades[0] >= 18) ? "Mayor de edad" : "Menor de edad";
            Console.WriteLine($"{listaNombres[0]} es {estado}.");
        }
        else
        {
            Console.WriteLine("LISTA COMPLETA:");
            for (int i = 0; i < listaNombres.Count; i++)
            {
                Console.WriteLine($"- {listaNombres[i]} ({listaEdades[i]} años)");
            }

            Console.WriteLine("\nMAYORES DE EDAD:");
            for (int i = 0; i < listaNombres.Count; i++)
            {
                if (listaEdades[i] >= 18) Console.WriteLine("- " + listaNombres[i]);
            }

            Console.WriteLine("\nMENORES DE EDAD:");
            for (int i = 0; i < listaNombres.Count; i++)
            {
                if (listaEdades[i] < 18) Console.WriteLine("- " + listaNombres[i]);
            }
        }
    }
}
(mejor que se quede asi, ahora dime como mandarlo a mi libreria)