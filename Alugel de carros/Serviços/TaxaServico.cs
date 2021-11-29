using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Serviços
{
    //Criando a interface taxa de serviço
    interface TaxaServico
    {
        //Criando a variável taxa e passando como parametro um valor tipo double
        double Taxa(double valor);
    }
}
