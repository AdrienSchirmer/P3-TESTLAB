using System;

public class Program
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

    public static void Main(string[] args)
    {
        Joc();
    }

    public static void calcul(out int coordenadax, out int coordenaday)
    {
        coordenadax = random.Next(0, 9); // Ajustado para incluir 8 en el rango
        coordenaday = random.Next(0, 9);
    }

    public static int TiradaJugador(int[,] diana, int coordenadax, int coordenaday)
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
            calcul(out int coordenadax1, out int coordenaday1);
            jugador1 += TiradaJugador(diana, coordenadax1, coordenaday1);

            calcul(out int coordenadax2, out int coordenaday2);
            jugador2 += TiradaJugador(diana, coordenadax2, coordenaday2);
        }

        string resultatFinal = Resultat(jugador1, jugador2);
        Console.WriteLine(resultatFinal);
    }
}