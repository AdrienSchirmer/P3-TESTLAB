using System;

namespace TestProject1;
class JocDiana
{
    static Random random = new Random();
    private static int[,] diana =
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
    private static int coordenadax = 0;
    private static int coordenaday = 0;

    public static void calcul(Random random)
    {
        coordenadax = random.Next(0, 8);
        coordenaday = random.Next(0, 8);
    }
    public static int TiradaJugador(int [,] diana, int coordenadax, int coordenaday)
    {
        return diana[coordenadax, coordenaday];
    }

    public static string Resultat(int jugador1, int jugador2)
    {
        if (jugador1 > jugador2)
        {
            return $"Ha guanyat el jugador 1 {jugador1} a {jugador2}";
        }
        else if (jugador1 < jugador2)
        {
            return $"Ha guanyat el jugador 2 {jugador2} a {jugador1}";
        }
        return "Empat";
    }
    
    public static void Joc()
    {
        int jugador1 = 0;
        int jugador2 = 0;

        while (jugador1 < 50 && jugador2 < 50)
        {
            jugador1 += TiradaJugador();
            jugador2 += TiradaJugador();
        }

        string resultatFinal = Resultat(jugador1, jugador2);
        Console.WriteLine(resultatFinal);
    }
    
    public static void Main(string[] args)
    {
        Joc();
    }
}