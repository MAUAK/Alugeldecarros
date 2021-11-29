using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Serviços
{
    //Criando a classe taxa serviço do Brasil
    class TaxaServicoBR : TaxaServico
    {
        //Criando a variavel taxa e passando um parametro para ela
        public double Taxa(double valor)
        {
            //Comparando se o parametro é menor ou igual a cem
            if (valor <= 100.00)
            {
                //Retornar o valor multiplicado a 0.2
                return valor * 0.2;
            }
            //Se não for
            else
            {
                //Retornar o valor multiplicado a 0.15
                return valor * 0.15;
            }
        }
    }
}
