using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone(numero : "123456", modelo: "iphone 14", imei: "123456789", memoria: "120");
iphone.Ligar();
iphone.InstalarAplicativo("spotify");

Console.WriteLine("\n");

Nokia nokia = new Nokia(numero : "654321", modelo: "nokia dobravel", imei: "987654321", memoria: "64");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");





