using DesafioPOO.Models;

Console.WriteLine("Smarth Nokia");
Smartphone nokia = new Nokia(numero: "1234567890", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarth iPhone");
Smartphone iphone = new Iphone(numero: "9876543210", modelo: "Modelo 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");