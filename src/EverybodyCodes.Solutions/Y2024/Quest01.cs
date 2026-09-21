namespace EverybodyCodes.Solutions.Y2024;

public static class Quest01
{
    public static int Part1(string notes)
    {
        var sumOfPotions = 0;

        foreach (var c in notes)
        {
            sumOfPotions += NumberOfPotions(c);
        }

        return sumOfPotions;
    }

    public static int Part2(string notes)
    {
        var sumOfPotions = 0;

        for (var i = 0; i < notes.Length; i += 2)
        {
            sumOfPotions += NumberOfPotions(notes[i]);
            sumOfPotions += NumberOfPotions(notes[i + 1]);

            if (notes[i] != 'x' && notes[i + 1] != 'x')
            {
                sumOfPotions += 2;
            }
        }
        return sumOfPotions;
    }

    public static int Part3(string notes)
    {
        var sumOfPotions = 0;

        for (var i = 0; i < notes.Length; i += 3)
        {
            sumOfPotions += NumberOfPotions(notes[i]);
            sumOfPotions += NumberOfPotions(notes[i + 1]);
            sumOfPotions += NumberOfPotions(notes[i + 2]);

            if (notes[i] != 'x' && notes[i + 1] != 'x' && notes[i + 2] != 'x')
            {
                sumOfPotions += 6;
            }
            else if (notes[i] != 'x' && notes[i + 1] != 'x')
            {
                sumOfPotions += 2;
            }
        }
        return sumOfPotions;
    }


    private static int NumberOfPotions(char c) => c switch
    {
        'B' => 1,
        'C' => 3,
        'D' => 5,
        _ => 0
    };
}