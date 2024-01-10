using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Realizando teste da classe Nokia.");
Smartphone nokia = new Nokia("9999-9999", "Teste1", "55555", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Realizando teste da classe Iphone");
Smartphone iphone = new Iphone("7777-7777", "x15", "55544", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitch");
