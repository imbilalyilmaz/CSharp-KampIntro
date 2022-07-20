// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { dataBaseLoggerService, fileLoggerService, new SmsLoggerService()});

List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager, tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


