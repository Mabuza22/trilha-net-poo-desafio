using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// NOKIA
Console.WriteLine("NOKIA");
Smartphone nokia1 = new Nokia(numero: "12345678910", modelo: "Nokia 1", imei: "3524783218", memoria: 128);
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Instagram");


Console.WriteLine("########################################");


// IPHONE
Console.WriteLine("IPHONE");
Smartphone iphone1 = new Iphone(numero: "10987654321", modelo: "Iphone 1", imei: "7218942375", memoria: 256);
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("TikTok");