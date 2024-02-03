using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco_rambank.Classes
{
    public class Conta
    {
        public Conta(Titular titular, int agencia, int accountnumber, double saldo, double limite)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroDaConta = accountnumber;
            Saldo = saldo;
            Limite = limite;
        }

        
        public Titular Titular {get; set;}
        public int Agencia {get; set;}
        public int NumeroDaConta {get; set;}
        public double Saldo {get;}
        public double Limite {get; set;}

        public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";


        
    }
}
