using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banco_rambank.Classes
{
    public class Conta
    {
        public int AccountNumber { get; set; }
        protected decimal Saldo = 3000;
        private string Password { get; set; }
        public Titular titular = new Titular();

        public void CreatePassword (string password)
        {
            Password = password;
        }


        public void ExibirInformacoes()
        {
            Console.WriteLine("Bem-vindo à área do cliente da RamBank.");
            Console.WriteLine($"Titular: {titular.Nome}");
            Console.WriteLine($"Número da conta: {AccountNumber}");
            Console.WriteLine($"Saldo: {Saldo}");
        }

        
    }
}