using Alugel_de_carros.Entidades;
using Alugel_de_carros.Serviços;
using System;
using System.Globalization;

namespace Alugel_de_carros
{
    //Kauam
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados da locação:");
            Console.Write("modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Check -in (dd / MM / yyyy HH: mm): ");
            DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check -out (dd / MM / yyyy HH: mm): ");
            DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            AluguelCarro aluguelCarro = new AluguelCarro(checkin, checkout, new Veiculo(modelo));
            ServicoLocacao servicoLocacao = new ServicoLocacao(hora, dia, new TaxaServicoBR());
            servicoLocacao.ProcessoFatura(aluguelCarro);
            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
