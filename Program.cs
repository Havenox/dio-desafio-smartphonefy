using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("55454599", "5125", "11111111", 512);
Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n\n");

Iphone iphone = new Iphone("999999", "15", "1111112", 1024);
Console.WriteLine("Smartphone iPhone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");