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
            var monsterCount = 0;
            for (var a = 0; a <= 2; a++)
            {
                sumOfPotions += NumberOfPotions(notes[i + a]);
                monsterCount += (notes[i + a] != 'x' ? 1 : 0);
            }

            sumOfPotions += monsterCount switch
            {
                3 => 6,
                2 => 2,
                _ => 0
            };
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