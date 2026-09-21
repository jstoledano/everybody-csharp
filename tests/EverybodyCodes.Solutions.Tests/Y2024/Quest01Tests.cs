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

    [Theory]
    [InlineData("", 0)]
    public void Part1_EmptyLinesOfMonsters(string notes, int expectedPotions)
    {
        // Act
        int result = EverybodyCodes.Solutions.Y2024.Quest01.Part1(notes);

        // Assert
        Assert.Equal(expectedPotions, result);
    }


    [Theory]
    [InlineData("AxBCDDCAxD", 28)]
    public void Part2_CalculatesCorrectNumberOfPotions(string notes, int expectedPotions)
    {
        // Act
        var result = EverybodyCodes.Solutions.Y2024.Quest01.Part2(notes);

        // Assert
        Assert.Equal(expectedPotions, result);
    }

    [Theory]
    [InlineData("xBxAAABCDxCC", 30)]
    public void Part3_CalculatesCorrectNumberOfPotions(string notes, int expectedPotions)
    {
        // Act
        var result = EverybodyCodes.Solutions.Y2024.Quest01.Part3(notes);

        // Assert
        Assert.Equal(expectedPotions, result);
    }
}