namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string marca, double memoria)
        : base(numero, modelo, marca, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store do iPhone.");
    }
}
}
