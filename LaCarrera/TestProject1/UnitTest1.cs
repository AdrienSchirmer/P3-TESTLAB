namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var Program = new Carrera();
        // Arrange
        int[,] carrera = {
            { 2, 4, 3, 5, 4 },  // Només dades per al jugador 2
        };
        int jugador = 1;  // Jugador 1 no existeix a la carrera
        int numeromespetit = int.MaxValue;
        int numeromesgran = int.MinValue;

        // Act
        int resultat = Program.CalcularResultatJugador(carrera, jugador, numeromespetit, numeromesgran);

        // Assert
        Assert.Equal(0, resultat); // No hi ha entrades per al jugador 1
    }
}