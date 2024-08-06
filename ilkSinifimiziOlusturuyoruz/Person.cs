using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilkSinifimiziOlusturuyoruz
{
    public class Person
    {
        public string ad;
        public string soyad;
        public string statue;
        public int dogumTarihi;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public string Statue
        {
            get
            {
                return statue;
            }
            set
            {
                statue = value;
            }
        }
        public int DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                if (value > 0)
                {
                    dogumTarihi = value;
                }
                else
                {
                    Console.WriteLine("Yanlış doğum tarihi girdiniz");
                }
            }
        }
        public void Bilgiler()
        {
            Console.WriteLine("\nAdı: " + ad);
            Console.WriteLine("Soyadı: " + soyad);
            Console.WriteLine("Statü: " + statue);
            Console.WriteLine("Doğum Tarihi: " + dogumTarihi);
        }
    }

}
