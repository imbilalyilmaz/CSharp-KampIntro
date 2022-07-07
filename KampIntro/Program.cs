// See https://aka.ms/new-console-template for more information

string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 21;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;
double dolarDun = 7.45;
double dolarBugun = 7.55;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Butonu");
}
else if(dolarBugun>dolarDun)
{
    Console.WriteLine("Artış Butonu");
}
else
{
    Console.WriteLine("değişmedi butonu");
}

if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş Yap Butonu");
}


Console.WriteLine(kategoriEtiketi);


int sayi1 = 0;
int sayi2 = 15;

string sonuc = (sayi1 > sayi2) ? "Sayi 1 Büyük" : "Sayi 2 Büyük";

Console.WriteLine(sonuc);


switch (sayi1)
{
    case 1:
        Console.WriteLine("Sayınız 1");
        break;
    case 2:
        Console.WriteLine("Sayınız 2");
        break ;
    case 3:
        Console.WriteLine("Sayınız 3");
        break;
    case 4:
        Console.WriteLine("Sayınız 4");
        break;
    case 5:
        Console.WriteLine("Sayınız 5");
        break;
    default:
        Console.WriteLine("Sayınız 5'den büyük.");
        break;
}


while (true)
{
    if (sayi1 == 11)
    {
        Console.WriteLine("Doldu.");
        break;
    }
    Console.WriteLine(sayi1);
    sayi1 = sayi1 + 1;
}
