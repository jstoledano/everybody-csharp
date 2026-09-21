namespace EverybodyCodes.Solutions.Y2024;

public static class Quest01
{
    public static int Part1(string notes)
    {
        int sumOfPotions = 0;

        foreach (char c in notes)
        {
            sumOfPotions += c switch
            {
                'B' => 1,
                'C' => 3,
                _ => 0
            };
        }

        return sumOfPotions;
    }
}