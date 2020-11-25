using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("escrevendoComAClasse.txt", "Testando File.WriteAllText");
            Console.WriteLine("Arquivo escrevendoComAClasse criado!");


            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivos contas.txt possui {bytesArquivo.Length} bytes.");


            Console.ReadLine();
            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();






            Console.WriteLine("Digite o seu nome: ");
            var nome = Console.ReadLine();


            UsarStreamDeEntrada();

            Console.WriteLine("Aplicação finalizada...");

            Console.ReadLine();
        }



    }
}
