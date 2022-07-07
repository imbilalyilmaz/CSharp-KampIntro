// See https://aka.ms/new-console-template for more information

string[] kurslar = new string[] {"Kurs1" , "Kurs2" , "Kurs3" };


for (int i = 0  ; i < 3; i++)
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa Sonu");