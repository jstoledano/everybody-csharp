using System.Text;
using System.Text.RegularExpressions;

namespace EverybodyCodes.Solutions.Y2024;

public static class Quest02
{
    public record Helmet
    {
        public string[] Words { get; init; } = Array.Empty<string>();
        public string RunicWords { get; init; } = string.Empty;
    }


    public static int Part1(string input)
    {
        int sumOfRunicWords = 0;

        var result = ParseNotes(input);

        foreach (var word in result.Words)
        {
            sumOfRunicWords += Regex.Count(result.RunicWords, pattern: word);
        }

        return sumOfRunicWords;
    }

    public static Helmet ParseNotes(string input)
    {
        // Normaliza saltos de línea y separa en líneas no vacías
        var lines = input
            .Replace("\r\n", "\n")
            .Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        // Primera línea: "WORDS:THE,OWE,MES,ROD,HER"
        var wordsLine = lines[0];
        var wordsPart = wordsLine["WORDS:".Length..]; // "THE,OWE,MES,ROD,HER"
        var words = wordsPart.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        // Segunda línea: la frase rúnica
        var runicWords = lines[1];

        return new Helmet
        {
            Words = words,
            RunicWords = runicWords
        };
    }


}