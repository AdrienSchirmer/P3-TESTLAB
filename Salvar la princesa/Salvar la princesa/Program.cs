namespace Salvar_la_princesa;

class Program
{
    static int Escut = 0;
    static int Casc = 0;
    static int Armadura = 0;
    static int Llança = 0;
    static int Espasa = 0;
    
    static void Main(string[] args)
    {
        string[] armes =
        {
            "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", "Escut", "Casc", "Armadura", "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut", 
            "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança", "Llança", "Espasa", "Armadura", "Escut", "Escut", "Armadura", "Armadura", "Llança", "Armadura", "Espasa", "Escut", 
            "Casc", "Escut", "Espasa", "Armadura", "Armadura", "Casc", "Casc", "Llança", "Casc", "Escut", "Escut", "Llança", "Llança", "Casc", "Espasa", "Armadura", "Casc", "Armadura", 
            "Espasa", "Llança", "Casc", "Llança", "Llança", "Espasa", "Casc", "Espasa", "Casc", "Armadura", "Casc", "Casc", "Armadura", "Llança", "Escut", "Escut", "Armadura", "Llança", 
            "Espasa", "Casc", "Llança", "Armadura", "Espasa", "Casc", "Escut", "Armadura", "Llança", "Llança", "Casc", "Casc", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Armadura", 
            "Espasa", "Espasa", "Armadura", "Escut", "Armadura", "Espasa", "Casc", "Llança", "Armadura", "Casc", "Armadura", "Llança", "Casc", "Escut", "Espasa", "Casc", "Casc", "Llança", "Llança", 
            "Armadura", "Casc", "Llança", "Llança", "Espasa", "Llança", "Armadura", "Casc", "Casc", "Escut", "Casc", "Llança", "Casc", "Escut", "Llança", "Escut", "Espasa", "Escut", "Llança", 
            "Armadura", "Casc", "Escut", "Espasa", "Llança", "Llança", "Casc", "Escut", "Casc", "Espasa", "Escut", "Escut", "Llança", "Llança", "Llança", "Llança", "Casc", "Escut", "Armadura", "Llança", "Casc", "Espasa", "Espasa",
        };
        
        comptarsubministres(armes);
        var numerocavallers = comptarcavallers();
        var numeropagesos = comptarpagesos();
        var numerosoldats = comptarsoldats();
        MostraInformacio(numerocavallers, numeropagesos, numerosoldats);
    }
    


    static void comptarsubministres(string[] armes)
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

    static int comptarcavallers()
    {
        int comptarcavallers = 0;
        while(Armadura > 0)
        {
            if (Armadura > 0 && Casc > 0 && Llança > 0 && Escut > 0)
            {
                Armadura--;
                Casc--;
                Llança--;
                Escut--;
                comptarcavallers++;
            }
        }
        return comptarcavallers;
    }

    static int comptarpagesos()
    {
        int comptarpagesos = 0;
        while (Llança > 0)
        {
            Llança--;
            comptarpagesos++;
        }
        return comptarpagesos;
    }

    static int comptarsoldats()
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
    
    static void MostraInformacio(int numerocavallers, int numeropagesos, int numerosoldats){
        Console.WriteLine("Cavallers: " + numerocavallers);
        Console.WriteLine("Soldats: " + numerosoldats);
        Console.WriteLine("Pagesos: " + numeropagesos);
    }
}