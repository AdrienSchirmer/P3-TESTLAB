namespace TestProject1;

public class Carrera
{
        private int numeromesgran = Int32.MinValue;
        private int numeromespetit = Int32.MaxValue;

        private int[,] carrera = {
            { 1,4,3,5,4 },
            { 2,8,2,5,7 },
            { 3,7,4,6,2 },
            { 4,4,3,1,3 },
            { 1,6,2,9,9 },
            { 2,6,9,9,5 },
            { 3,6,1,6,4 },
            { 4,9,4,1,6 },
            { 1,4,4,5,2 },
            { 2,6,2,2,1 },
            { 3,8,6,8,6 },
            { 4,1,8,8,1 },
            { 1,9,7,8,6 },
            { 2,7,8,2,3 },
            { 3,4,1,2,5 },
            { 4,2,6,2,9 },
            { 1,3,3,4,9 },
            { 2,1,2,1,5 },
            { 3,1,3,3,1 },
            { 4,7,9,3,2 },
            { 1,7,1,9,6 },
            { 2,3,4,5,7 },
            { 3,5,3,7,9 },
            { 4,9,2,3,2 },
            { 1,3,8,5,5 },
            { 2,7,9,9,6 },
            { 3,9,6,6,1 },
            { 4,7,2,1,4 },
            { 1,7,8,4,2 },
            { 2,6,1,8,3 },
            { 3,4,4,2,6 },
            { 4,2,3,5,2 },
            { 1,1,5,6,1 },
            { 2,7,9,4,3 },
            { 3,5,4,6,5 },
            { 4,9,5,1,7 },
            { 1,8,9,4,5 },
            { 2,6,6,2,2 },
            { 3,5,2,4,9 },
            { 4,4,5,7,6 }
        };

        public void calcul()
        {
            int[] totals = new int[4];
            for (int jugador = 1; jugador <= 4; jugador++)
            {
                totals[jugador - 1] = CalcularResultatJugador(carrera, jugador, numeromespetit, numeromesgran);
            }
            DeterminarGuanyador(totals);
        }
            
        

        public int CalcularResultatJugador(int[,] carrera, int jugador, int numeromespetit, int numeromesgran)
        {
            int resultat = 0;
            Console.Write($"Corredor {jugador}");
            for (int participant = 0; participant < carrera.GetLength(0); participant++)
            {
                if (carrera[participant, 0] == jugador)
                {
                    for (int i = 1; i <= carrera.GetLength(1) - 1; i++)
                    {
                        if (carrera[participant, i] < numeromespetit)
                        {
                            numeromespetit = carrera[participant, i];
                        }
                        if (carrera[participant, i] > numeromesgran)
                        {
                            numeromesgran = carrera[participant, i];
                        }
                    }
                    resultat += numeromesgran - numeromespetit;
                    numeromesgran = Int32.MinValue;
                    numeromespetit = Int32.MaxValue;
                }
            }
            Console.Write($"= {resultat} metres");
            Console.WriteLine();
            return resultat;
        }

        public static void DeterminarGuanyador(int[] totals)
        {
            string[] corredors = { "Corredor 1", "Corredor 2", "Corredor 3", "Corredor 4" };
            string corredorGuanyador = "";
            int millorTemps = int.MinValue;

            for (int i = 0; i < totals.Length; i++)
            {
                if (totals[i] >= millorTemps)
                {
                    millorTemps = totals[i];
                    corredorGuanyador = corredors[i];
                }
            }

            Console.WriteLine($"La carrera l’ha guanyat el {corredorGuanyador}!");
        }
}