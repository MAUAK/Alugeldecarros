using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Alugel_de_carros.Entidades
{
    class Fatura
    {
        public double Pagamento { get; set; }
        public double Taxa { get; set; }
        public Fatura(double aluguel, double taxa)
        {
            Pagamento = aluguel;
            Taxa = taxa;
        }
        public double totalPagamento
        {
            get { return Pagamento + Taxa; }
        }
        public override string ToString()
        {
            return "Pagamento: "
            + Pagamento.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTaxa: "
            + Taxa.ToString("F2", CultureInfo.InvariantCulture)
            + "\nPagamento total: "
            + totalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
