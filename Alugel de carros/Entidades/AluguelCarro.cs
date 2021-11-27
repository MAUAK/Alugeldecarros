using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Entidades
{
    class AluguelCarro
    {
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }
        public AluguelCarro(DateTime checkin, DateTime checkout, Veiculo veiculo)
        {
            Checkin = checkin;
            Checkout = checkout;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
