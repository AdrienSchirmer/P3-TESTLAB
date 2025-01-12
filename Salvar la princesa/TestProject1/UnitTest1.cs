namespace TestProject2;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange: crear les armes que volem provar
        string[] armes = {
            "Escut", "Casc", "Espasa", "Escut", "Espasa", "Casc", "Armadura", "Llança", "Escut", 
            "Escut", "Casc", "Armadura", "Escut", "Llança", "Espasa", "Escut", "Llança", "Escut",
            "Espasa", "Casc", "Casc", "Escut", "Espasa", "Llança", "Llança", "Espasa", "Armadura"
        };

        // Arrange: comptem els subministraments amb la funció
        Salvar_la_princesa.SalvarLaPrincesa.ComptarSubministres(armes);

        // Act: comptem cavallers, pagesos i soldats
        var numerocavallers = Salvar_la_princesa.SalvarLaPrincesa.ComptarCavallers();
        var numeropagesos = Salvar_la_princesa.SalvarLaPrincesa.ComptarPagesos();
        var numerosoldats = Salvar_la_princesa.SalvarLaPrincesa.ComptarSoldats();

        // Assert: comprovem que els resultats són els esperats
        Assert.Equal(2, numerocavallers); // S'esperen 2 cavallers
        Assert.Equal(4, numeropagesos);  // S'esperen 4 pagesos
        Assert.Equal(1, numerosoldats);  // S'esperen 1 soldat
    }
}