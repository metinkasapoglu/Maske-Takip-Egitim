﻿using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        //Degiskenler();

        Vatandas vatandas1 = new Vatandas();

        SelamVer("Engin");
        SelamVer("Ahmet");
        SelamVer();

        int sonuc = Topla(50,5);

       
        //Diziler /Arrays
        string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        for(int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }


        //arrays, class, interface ve abstract referans tiptir.


        string[] sehirler1 = new[] {"Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır"};

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";
        Console.WriteLine(sehirler2[0]);

        //int, double, float,bool değer tiplerdir

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2);

        Person person1 = new Person();
        person1.FirstName = "Beyza";
        person1.LastName = "Aydoğanoğlu";
        person1.DateOfBirthYear = 2001;
        person1.Nationalİdentity = 132546;

        Person person2 = new Person();
        person2.FirstName = "Murat";


        foreach (string sehir in sehirler1)
        {
            Console.WriteLine (sehir);
        }

        List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
        yeniSehirler1.Add("Adana 1");
        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);


        Console.ReadLine();

    }

    static void SelamVer(string isim="isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1=5, int sayi2=10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam : " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        string mesaj = "Selam";
        double tutar = 10000;  //db den gelir
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Engin";
        string soyad = "Demiroğ";
        int dogumYili = 1985;
        long tcNo = 12345678910;


        Console.WriteLine(tutar * 1.18);
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public  string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}

