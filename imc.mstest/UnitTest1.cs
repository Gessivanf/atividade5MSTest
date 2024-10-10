namespace imc.mstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;

        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();

        Assert.AreEqual(imc_previsto, i.imc);

    }

    [TestMethod]
    [DataRow("Abaixo do peso")]
    [DataRow("Peso normal")]
    [DataRow("Sobrepeso")]
    [DataRow("Obesidade de grau I")]
    [DataRow("Obesidade de grau II")]
    [DataRow("Obesidade de grau III")]
    public void Teste_Categoria_IMC(string cat)
    {
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.AreNotEqual(i.categoria, cat);
    }
}