using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11221122", memoria: 64);
nokia.NumeroSmartphone();
nokia.NomeModelo();
nokia.NumeroIMEI();
nokia.QuantidadeMemoria();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "789123", modelo: "Modelo 2", imei: "33443344", memoria: 128);
iphone.NumeroSmartphone();
iphone.NomeModelo();
iphone.NumeroIMEI();
iphone.QuantidadeMemoria();
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
