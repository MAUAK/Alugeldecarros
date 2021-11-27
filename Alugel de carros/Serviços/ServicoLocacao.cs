using Alugel_de_carros.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Serviços
{
    class ServicoLocacao
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }
        private TaxaServico _taxaServico;
        public ServicoLocacao(double precoPorHora, double precoPorDia, TaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaServico = taxaServico;
        }
        public void ProcessoFatura(AluguelCarro aluguelCarro)
        {
            TimeSpan duration = aluguelCarro.Checkout.Subtract(aluguelCarro.Checkin);
            double pagamento = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                pagamento = PrecoPorHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                pagamento = PrecoPorDia * Math.Ceiling(duration.TotalDays);
            }
            double taxa = _taxaServico.Taxa(pagamento);
            aluguelCarro.Fatura = new Fatura(pagamento, taxa);
        }
    }
}
