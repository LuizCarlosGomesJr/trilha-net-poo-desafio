using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "98765432", modelo: "Modelo Nokia 1", imei: "101100010", memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero: "13589651", modelo: "Modelo Iphone 1", imei: "101100010", memoria: 256 );
iphone.Ligar();
iphone.InstalarAplicativo("Teams");
