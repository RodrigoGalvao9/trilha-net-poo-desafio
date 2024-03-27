using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456",  modelo: "modelo 1", imei: "111111", memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero: "56789",  modelo: "modelo 2", imei: "222222", memoria: 56);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");