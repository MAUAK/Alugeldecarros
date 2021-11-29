using Alugel_de_carros.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Serviços
{
    //Criando a classe de serviço de locação
    class ServicoLocacao
    {
        //Criando a variável preço por hora e encapsulando ela
        public double PrecoPorHora { get; private set; }
        //Criando a variável preço por dia e encapsulando ela
        public double PrecoPorDia { get; private set; }
        //Instanciando a interface taxa de serviço
        private TaxaServico _taxaServico;
        //Criando o construtor de serviço locação e igualando as variaveis com os parametros
        public ServicoLocacao(double precoPorHora, double precoPorDia, TaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }
        //Criando o métodos de processar a fatura com o paramêtro do aluguel do carro
        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            //Criando a variável de duração e definindo ela como a data de saída menos a datá de entrada
            TimeSpan duration = aluguelCarro.Checkout.Subtract(aluguelCarro.Checkin);
            //Criando a variável de pagamento e difinido o valor dela para 0
            double pagamento = 0.0;
            //Comparando se o valor da variável duração é menos que 12
            if (duration.TotalHours <= 12.0)
            {
                //Definindo que o valor da varável pagamento será o valor de preço por hora multiplicado a duração
                pagamento = PrecoPorHora * Math.Ceiling(duration.TotalHours);
            }
            //Caso a comparação seja falsa
            else
            {
                //O pagamento será o preço por dia multiplicado a duração
                pagamento = PrecoPorDia * Math.Ceiling(duration.TotalDays);
            }
            //Declarando a variável taxa e definindo que ela é igual ao pagamento da taxa de serviço
            double taxa = _taxaServico.Taxa(pagamento);
            //Criando uma nova fatura no alguel do carro com as informações de pagamento e taxa
            aluguelCarro.Fatura = new Fatura(pagamento, taxa);
        }
    }
}
