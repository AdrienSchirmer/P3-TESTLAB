namespace Salvar_la_princesa;

public class SalvarLaPrincesa
{
    private static int Escut = 0;
    private static int Casc = 0;
    private static int Armadura = 0;
    private static int Llança = 0;
    private static int Espasa = 0;

    // Mètode per comptar els subministraments
    public static void ComptarSubministres(string[] armes)
    {
        for (int i = 0; i < armes.Length; i++)
        {
            if (armes[i] == "Casc")
            {
                Casc++;
            }
            else if (armes[i] == "Escut")
            {
                Escut++;
            }
            else if (armes[i] == "Armadura")
            {
                Armadura++;
            }
            else if (armes[i] == "Llança")
            {
                Llança++;
            }
            else if (armes[i] == "Espasa")
            {
                Espasa++;
            }
        }
    }

    // Mètode per comptar els cavallers
    public static int ComptarCavallers()
    {
        int comptarcavallers = 0;
        while (Armadura > 0 && Casc > 0 && Llança > 0 && Escut > 0)
        {
            Armadura--;
            Casc--;
            Llança--;
            Escut--;
            comptarcavallers++;
        }
        return comptarcavallers;
    }

    // Mètode per comptar els pagesos
    public static int ComptarPagesos()
    {
        int comptarpagesos = 0;
        while (Llança > 0)
        {
            Llança--;
            comptarpagesos++;
        }
        return comptarpagesos;
    }

    // Mètode per comptar els soldats
    public static int ComptarSoldats()
    {
        int comptarsoldats = 0;
        while (Casc > 0 && Espasa > 0 && Escut > 0)
        {
            Casc--;
            Espasa--;
            Escut--;
            comptarsoldats++;
        }
        return comptarsoldats;
    }

    // Mètode per mostrar la informació
    public static string MostraInformacio(int numerocavallers, int numeropagesos, int numerosoldats)
    {
        return $"Cavallers: {numerocavallers}\nSoldats: {numerosoldats}\nPagesos: {numeropagesos}";
    }
}
