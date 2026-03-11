using ByteBankIO;
using System.Numerics;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        CriandoArquivo();
        Console.ReadLine();
    }

    /*static ContaCorrente ConvertendoTextoParaConta(string linha)
    {
        string [] campos = linha.Split(',');
        int agencia = int.Parse(campos[0]);
        int numero = int.Parse(campos[1]);
        double saldo = double.Parse(campos[2]);
        var titular = new Cliente();
        titular.Nome = campos[3];
        var conta = new ContaCorrente(agencia, numero);
        conta.Depositar(saldo);
        conta.Titular = titular;
        return conta;
    }*/
}