using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace superfort;

public class CalculaViatgesTest
{
    [Theory]
    [InlineData(3, 10, 7, 2, 3, 9)]
    [InlineData(1, 10, 1, 1, 1, 1)]
    [InlineData(4, 10, 9, 9, 9, 9)]
    [InlineData(1, 10, 10)]
    [InlineData(-1, 10, 11)]
    [InlineData(-1, 10, -1)]
    public void Test1(int expected, int maxim, params int[] paquets)
    {
        // Arrange

        // Act
        var resultat = Program.CalculaViatges(maxim, paquets);

        // Assert
        Assert.Equal(expected, resultat);

    }

    [Fact]
    void ComprovaQuePassaSiLaLlistaEsBuida()
    {
        // Arrange
        var llista = new int[] { };
        var maxim = 3;
        var expected = -1;

        // Act
        var resultat = Program.CalculaViatges(maxim, llista);

        // Assert
        Assert.Equal(expected, resultat);

    }
}
