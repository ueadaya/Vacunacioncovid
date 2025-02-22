using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear un conjunto ficticio de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add($"Ciudadano {i}");
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add($"Ciudadano {i}");
        }

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
        {
            vacunadosAstraZeneca.Add($"Ciudadano {i}");
        }

        // Listado de ciudadanos que no se han vacunado
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // Listado de ciudadanos que han recibido las dos vacunas
        HashSet<string> ambasVacunas = new HashSet<string>(vacunadosPfizer);
        ambasVacunas.IntersectWith(vacunadosAstraZeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Mostrar resultados en la consola
        Console.WriteLine("=== Listado de ciudadanos no vacunados ===");
        foreach (var ciudadano in noVacunados)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\n=== Listado de ciudadanos con ambas vacunas ===");
        foreach (var ciudadano in ambasVacunas)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\n=== Listado de ciudadanos solo con Pfizer ===");
        foreach (var ciudadano in soloPfizer)
        {
            Console.WriteLine(ciudadano);
        }

        Console.WriteLine("\n=== Listado de ciudadanos solo con AstraZeneca ===");
        foreach (var ciudadano in soloAstraZeneca)
        {
            Console.WriteLine(ciudadano);
        }
    }
}