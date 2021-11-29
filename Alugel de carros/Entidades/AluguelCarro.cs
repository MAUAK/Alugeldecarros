using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Entidades
{
    //Criando a classe AluguelCarro
    class AluguelCarro
    {
        //Criando a variável de chek-in (tipo data e tempo)
        public DateTime Checkin { get; set; }
        //Criando a variável de chek-out (tipo data e tempo)
        public DateTime Checkout { get; set; }
        //Instanciando a classe veiculo e encapsulando ela em uma variavel
        public Veiculo Veiculo { get; private set; }
        //Instanciando a classe fatura e encapsulando ela em uma variavel
        public Fatura Fatura { get; set; }
        //Criando o contrutor do aluguelcarro e igualando suas variáveis com os paramêtros das outras classes
        public AluguelCarro(DateTime checkin, DateTime checkout, Veiculo veiculo)
        {
            Checkin = checkin;
            Checkout = checkout;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
