using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Alugel_de_carros.Entidades
{
    class Fatura
    {
        //Criando a variável de pagamento e encapsulando ela
        public double Pagamento { get; set; }
        //Criando a variável de taxa e encapsulando ela
        public double Taxa { get; set; }
        //Criando o construtor Fatura e igualando sua variaveis com seus parametros
        public Fatura(double aluguel, double taxa)
        {
            Pagamento = aluguel;
            Taxa = taxa;
        }
        //Criando a variável de pagamento total 
        public double totalPagamento
        {
            //Definindo um valor para ela como formula
            get { return Pagamento + Taxa; }
        }
        //Criando o método de escrever as informações corretamente
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
