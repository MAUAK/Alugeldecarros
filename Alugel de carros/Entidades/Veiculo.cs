using System;
using System.Collections.Generic;
using System.Text;

namespace Alugel_de_carros.Entidades
{
    //Criando a classe veiculo
    class Veiculo
    {
        //Criando e encapsulando a variavel modelo
        public string Modelo { get; set; }
        //Criando o construtor veiculo e igualando a variavel modelo com o parametro
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
