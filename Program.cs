using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe Nokia
        Nokia nokia = new Nokia("123456789", "3310", "Nokia", 16);
        Console.WriteLine($"Marca: {nokia.Marca}, Modelo: {nokia.Modelo}, Número: {nokia.Numero}, Memória: {nokia.Memoria} GB");
        
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine(); // Linha em branco para separação

        // Criando uma instância da classe Iphone
        Iphone iphone = new Iphone("987654321", "13", "Apple", 128);
        Console.WriteLine($"Marca: {iphone.Marca}, Modelo: {iphone.Modelo}, Número: {iphone.Numero}, Memória: {iphone.Memoria} GB");
        
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Facebook");
    }
}
