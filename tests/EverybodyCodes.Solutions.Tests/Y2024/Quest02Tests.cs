namespace EverybodyCodes.Solutions.Tests.Y2024;

public class Quest02Test
{
    [Fact]
    public void ParseNotes_ExtractsWordsAndRunesCorrectly()
    {
        // Arrange
        string input = """
            WORDS:THE,OWE,MES,ROD,HER

            AWAKEN THE POWER ADORNED WITH THE FLAMES BRIGHT IRE
            """;

        string[] expectedWords = ["THE", "OWE", "MES", "ROD", "HER"];
        string expectedRunes = "AWAKEN THE POWER ADORNED WITH THE FLAMES BRIGHT IRE";

        // Act
        EverybodyCodes.Solutions.Y2024.Quest02.Helmet result = EverybodyCodes.Solutions.Y2024.Quest02.ParseNotes(input);

        // Assert
        Assert.Equal(expectedWords, result.Words);
        Assert.Equal(expectedRunes, result.RunicWords);
    }

    [Fact]
    public void Part1_ExampleFromQuest()
    {
        string input = """
        WORDS:THE,OWE,MES,ROD,HER

        AWAKEN THE POWER ADORNED WITH THE FLAMES BRIGHT IRE
        """;

        int result = EverybodyCodes.Solutions.Y2024.Quest02.Part1(input);

        Assert.Equal(4, result);
    }
}