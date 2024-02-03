using banco_rambank.Classes;

Titular matt = new Titular("Mateus Ramgund", "99999999999", "Rua Doze de Dezembro, PE");

Conta mateus = new Conta(matt, 123456, 123456, 3000, 6000);

Console.WriteLine(mateus.Informacoes);
