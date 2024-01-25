using banco_rambank.Classes;

Conta mateus = new Conta();
mateus.Titular = "Mateus Ramgund";
mateus.AccountNumber = 123456;
mateus.CreatePassword("mateus123");

mateus.ExibirInformacoes();