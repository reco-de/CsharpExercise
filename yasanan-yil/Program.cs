
int dateYear = DateTime.Now.Year;
int dateMonth =DateTime.Now.Month;
int dateDay = DateTime.Now.Day;

Console.Write("Doğum Yılınızı Giriniz:");
    int yourYear = int.Parse(Console.ReadLine());
    int yil = dateYear - yourYear ;

Console.Write("Doğum Ayınızı Giriniz:");
    int yourMonth = int.Parse(Console.ReadLine());
    int ay = dateMonth - yourMonth ;
    if (yourMonth > dateMonth)
    {
        yil = yil - 1 ;
        ay = ay + 12 ;
    }

Console.Write("Doğum Gününüzü Giriniz:");
    int yourDay = int.Parse(Console.ReadLine());
    if (yourDay > dateDay )
    {
        ay = ay - 1 ;
        dateDay = dateDay + 30;
    }
    int gun = dateDay - yourDay ;

    Console.Write("Siz doğalı " + yil + " yıl, " + ay +" ay, " + gun + " gün oldu :) ");

Console.Write("Kapatmak için 'Enter' tuşuna basınız.");
    Console.ReadLine();
