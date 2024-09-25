using DesafioPOO.Models;

Nokia nokia = new Nokia("4199988665544", "XPTO", "XYZ123", 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("jogo da cobrinha");

Iphone iphone = new Iphone("4199988665544", "XPTO", "XYZ123", 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Of Clans");