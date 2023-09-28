using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

var nokia = new Nokia("123456789", "G11 Plus", "135412135481312", 128);

nokia.Ligar();

nokia.ReceberLigacao();

nokia.InstalarAplicativo("Instagram");


var iphone = new Iphone("987654321", "Iphone 15 Pro Max","156666456132132", 512);

iphone.Ligar();

iphone.ReceberLigacao();

iphone.InstalarAplicativo("TikTok");