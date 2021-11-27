using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Serviços
{
    class TaxaServicoBR : TaxaServico
    {
        public double Taxa(double valor)
        {
            if (valor <= 100.00)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }
        }
    }
}
