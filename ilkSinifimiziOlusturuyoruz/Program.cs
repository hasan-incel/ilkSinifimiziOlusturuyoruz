using ilkSinifimiziOlusturuyoruz;

public class Program
{
    public static void Main()
    {
        Person person = new Person();

        person.ad = "Mert";
        person.soyad = "Sert";
        person.statue = "Öğrenci";
        person.dogumTarihi = 1998;
        person.Bilgiler();


        person.ad = "Derin";
        person.soyad = "Merin";
        person.statue = "Öğrenci";
        person.dogumTarihi = 1996;
        person.Bilgiler();


        person.ad = "Tan";
        person.soyad = "Büyük";
        person.statue = "Öğretmen";
        person.dogumTarihi = 1975;
        person.Bilgiler();


        person.ad = "Sıla";
        person.soyad = "Küçük";
        person.statue = "Öğretmen";
        person.dogumTarihi = 1980;
        person.Bilgiler();

    }
}
