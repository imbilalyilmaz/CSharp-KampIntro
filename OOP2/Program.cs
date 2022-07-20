// See https://aka.ms/new-console-template for more information
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Adi = "Bilal";
musteri1.TcNo = "1234567890";
musteri1.MusteriNo = "1";
musteri1.Id = 1;

TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.MusteriNo = "2";
musteri2.VergiNo = "123";
musteri2.Id = 2;
musteri2.SirketAdi = "Bilem Ne A.Ş.";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

CustomerManager musteriManager = new CustomerManager();
musteriManager.Add(musteri1);
musteriManager.Add(musteri2);
musteriManager.Add(musteri3);
musteriManager.Add(musteri4);
