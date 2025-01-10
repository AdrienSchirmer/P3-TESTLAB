namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var prog = new Carrera();
        // Configuració: una sola fila per al jugador 1
        int[,] carrera = {
            { 1, 4, 3, 5, 4 } // Jugador 1: valors 4, 3, 5, 4
        };
        int jugador = 1;
        int numeromespetit = Int32.MaxValue;
        int numeromesgran = Int32.MinValue;

        // Acció: cridem el mètode amb els valors configurats
        int resultat = prog.CalcularResultatJugador(carrera, jugador, numeromespetit, numeromesgran);

        // Comprovació: el resultat ha de ser 2 (màxim 5 - mínim 3)
        Assert.Equal(2, resultat);
    }
}