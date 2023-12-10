using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("7399988", "Modelo 1", "11111", 64);

nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Iphone: ");
Smartphone iphone = new Iphone("7399889", "Modelo 2", "00000", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");