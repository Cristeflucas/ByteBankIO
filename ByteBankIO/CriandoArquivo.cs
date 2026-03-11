using ByteBankIO;
using System.Text;
partial class Program
{
    static void CriandoArquivo()
    {
        var enderecoDoArquivo = "contasExportadas.csv"; 
        using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Pedro Silva";
            var enconding = Encoding.UTF8;
            var bytes = enconding.GetBytes(contaComoString);
            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }
}

