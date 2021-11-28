using Alugel_de_carros.Entidades;
using Alugel_de_carros.Serviços;
using System;
using System.Globalization;

namespace Alugel_de_carros
{
    //------------------------ KAUAM SILVA BATISTA - 210501 -------------
    class Program
    {
        static void Main(string[] args)
        {
            //Pedindo os dados da locação
            Console.WriteLine("Entre com os dados da locação:");
            //Pedindo o modelo e guardando em uma variável
            Console.Write("modelo: ");
            string modelo = Console.ReadLine();
            //Pedindo a data de entrada e guardando em uma variável
            Console.Write("Check-in (dd / MM / yyyy HH: mm): ");
            DateTime checkin = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo a data de saída e guardando em uma variável
            Console.Write("Check-out (dd / MM / yyyy HH: mm): ");
            DateTime checkout = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo a hora e guardando em uma variável
            Console.Write("Entre com o preço por hora: ");
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Pedindo o dia e guardando em uma variável
            Console.Write("Entre com preço por dia: ");
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Chamando o construtor da classe aluguel de carro
            AluguelCarro aluguelCarro = new AluguelCarro(checkin, checkout, new Veiculo(modelo));
            //Chamando o construtor da serviço locação de carro
            ServicoLocacao servicoLocacao = new ServicoLocacao(hora, dia, new TaxaServicoBR());
            //Chamando o método Processo Fatura da classe servicoLocacao
            servicoLocacao.ProcessoFatura(aluguelCarro);
            //Imprimindo a fatura (chamada da classe aluguelCarro)
            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
