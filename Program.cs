using banco_rambank.Classes;

Titular matt = new Titular();
matt.Nome = "Mateus Ramgund";

Conta mateus = new Conta();
mateus.AccountNumber = 123456;
mateus.CreatePassword("mateus123");

mateus.AdicionarTitular(matt);

mateus.ExibirInformacoes();
