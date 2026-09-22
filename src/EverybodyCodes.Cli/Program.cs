using EverybodyCodes.Solutions.Y2024;

// 1. Ejecución directa (Top-level statements). ¡No hay class Program ni static void Main!
// El compilador infiere que esto va dentro del punto de entrada principal.
Solve(2024, 1, 1, Quest01.Part1);
Solve(2024, 1, 2, Quest01.Part2);
Solve(2024, 1, 3, Quest01.Part3);

// Solve(2024, 1, 2, Quest01.Part2); // Listo para cuando devuelvas otro tipo de dato.

// 2. Definición del método estático genérico <T> en el mismo archivo
static void Solve<T>(int year, int quest, int part, Func<string, T> solution)
{
    string notesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", $"y{year}", $"quest{quest:D2}",
        $"part{part}.txt");

    if (!File.Exists(notesPath))
    {
        Console.WriteLine($"[!] Error: No se encontró el archivo de notas en {notesPath}");
        return;
    }

    string notes = File.ReadAllText(notesPath).Trim();

    T result = solution(notes);

    Console.WriteLine($"{year} · Quest {quest:D2} · Parte {part}: {result}");
}