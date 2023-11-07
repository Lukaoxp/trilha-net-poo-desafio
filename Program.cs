using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("(47)99999-9999", "Iphone 14 Pro Max", "351344358593116", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Subway Surfers");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(47)98888-8888", "Nokia C22", "352939271143896", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Zombie Tsunami");