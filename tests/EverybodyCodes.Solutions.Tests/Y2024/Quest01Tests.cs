namespace EverybodyCodes.Solutions.Tests.Y2024;

public class Quest01Tests
{
    [Theory]
    [InlineData("ABBAC", 5)]
    public void Part1_CalculatesCorrectNumberOfPotions(string notes, int expectedPotions)
    {
        // Act
        int result = EverybodyCodes.Solutions.Y2024.Quest01.Part1(notes);

        // Assert
        Assert.Equal(expectedPotions, result);
    }
}   