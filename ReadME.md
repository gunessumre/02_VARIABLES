# Ders2

## Konu: Variables

--------------
### Bu Derste Ogrendiklerimiz 
- Double Degiskenler
- Char Degiskenler
- Klavyeden Veri Girisleri
- Klavyeden Tam Sayi Girisleri ve Donusumler
- Klavyeden onldalikli Sayi Girisleri
- Klavyeden Karakter Girisleri
----------------------

## 1 Double Degiskenler
>Double degiskenler ondalikli islemler icin kullanilir.
### Ornek


    double number  
    number = 3.14;
    Console.WriteLine(number);

## Char Degiskenler

>Char (character) değişkenleri, genellikle bir karakteri saklamak için kullanilan veri türleridir.
Char degiskenler ' tek tirnak ile tanimlanir.

### Ornek

    char symbol;
    symbol = 'a';

## Klavyeden Veri Girisleri
> Klavyeden veri girisi, bir programin kullanicidan veri almasini saglar ve bu girisler genellikle farkli veri tiplerinde 
(karakter, tam sayi, ondalikli sayi, vs.) olabilir. 

> C# dilinde klavyeden veri almak için Console.ReadLine() fonksiyonu kullanilir.

    string ad,soyad;
            Console.WriteLine("Lutfen adinizi giriniz: ");
            ad = Console.ReadLine();
            Console.WriteLine("Lutfen soyadinizi giriniz: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Ad: " + ad);
            Console.WriteLine("Soyad:" + soyad);

   

 ## Klavyeden Tam Sayi Girisleri ve Donusumler

> Genellikle klavyeden veri alirken, girdiler varsayilan olarak string (metin) formatinda gelir. Eger bu girdileri tam sayi gibi farkli veri turlerinde kullanmak istiyorsaniz, 
> uygun dönüsüm islemlerini uygulamamiz gerekiyor.

### Dönüşüm İşlemleri

>Kullanicidan alinan veriyi tam sayiya cevirmek icin:
> 
>  Convert.ToInt32() veya int.Parse()
> 
  >kullanilir ve bu C# icin gecerlidir.

    using System;

     class Program
     {
       static void Main()
     {
         // Kullanicidan bir tam sayı girisi alinir (string olarak)
   
       Console.Write("Bir tam sayi girin: ");
       string girdi = Console.ReadLine();

        // String'i tam sayiya dönüştürme
        int sayi = Convert.ToInt32(girdi);

      // ya da int sayi= int.Parse(girdi); yazabiliriz

        // Tam sayi ciktisi
        Console.WriteLine("Girdiginiz tam sayı: " + sayi);

    }
    }

## Klavyeden onldalikli Sayi Girisleri

    // Kullanicidan bir ondalikli sayi girisi alinir (string olarak)
        
    Console.Write("Bir ondalikli sayi girin: ");
        string girdi = Console.ReadLine();
    
    // String'i ondalikli sayiya donuşturme (double turune donuşturuyoruz)
        double sayi = double.Parse(girdi);
     
    // Ondalikli sayi ciktisi
    Console.WriteLine("Girdiğiniz ondalikli sayı: " + sayi);

## Klavyeden Karakter Girisleri
    char gender;
            Console.Write("Lutfen cinsiyet seciniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Sectiginiz cinsiyet: "+ gender);


# Ozet

> - Double degiskenler ondalikli islemler icin kullanilir.
> - Char (character) değişkenleri, genellikle bir karakteri saklamak icin kullanilan 
veri türleridir. Char degiskenler '' tek tirnak ile tanimlanir.
> - Klavyeden veri girisi, bir programin kullanicidan veri almasini saglar ve bu girisler 
genellikle farkli veri tiplerinde (karakter, tam sayi, ondalikli sayi, vs.) olabilir.
> - C# dilinde klavyeden veri almak için Console.ReadLine() fonksiyonu kullanilir.









