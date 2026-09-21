using System;
using System.IO;


namespace EverybodyCodes.Cli
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Solve(2024, 1, 1, SolutionPart1);
            // Solve(2024, 1, 2, SolutionPart2);
        }

        static void Solve(int year, int quest, int part, Func<string, int> solution)
        {
            string notesPath = Path.Combine("resources", $"y{year}", $"quest{quest:D2}", $"part{part}.txt");

            if (!File.Exists(notesPath))
            {
                Console.WriteLine($"[!] Error: No se encontró el archivo de notas en {notesPath}");
                return;
            }

            string notes = File.ReadAllText(notesPath).Trim();
            int result = solution(notes);

            Console.WriteLine($"{year} · Quest {quest:D2} · Parte {part}: {result}");
        }

        static int SolutionPart1(string notes)
        {
            // tu lógica aquí
            return 0;
        }
    }
}