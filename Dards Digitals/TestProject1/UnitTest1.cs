namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        int[,] diana = 
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 1, 1, 1, 1, 1, 1, 1, 0},
            {0, 1, 2, 2, 2, 2, 2, 1, 0},
            {0, 1, 2, 1, 1, 1, 2, 1, 0},
            {0, 1, 2, 1, 5, 1, 2, 1, 0},
            {0, 1, 2, 1, 1, 1, 2, 1, 0},
            {0, 1, 2, 2, 2, 2, 2, 1, 0},
            {0, 1, 1, 1, 1, 1, 1, 1, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int coordenadax = 4; // Coordenada X per al test
        int coordenaday = 4; // Coordenada Y per al test

        // Act
        int resultat = Program.TiradaJugador(diana, coordenadax, coordenaday);

        // Assert
        Assert.Equal(5, resultat); // La posició (4, 4) té un valor de 5 a la matriu.
    }
}