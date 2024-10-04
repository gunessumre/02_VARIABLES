namespace _02_variables
{


    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE DEGISKENLER


           //  /* double degiskenler ondalikli islemler icin kullanilir. Integer sadece tamsayi kismiyla ilgilenirken duoble
           //   islemlerin ondalikli kisimlariyla da ilgilenir*/
           //  double number;
           //  number = 3.14;
           //  Console.WriteLine(number);
           //  /*kod tarafinda nokta olarak yazdigimiz sembol console ekraninda bize virgul olarak dondu o zaman buradan
           //  cikaricagimiz sonuc biz kod tarafinda ayirma ya da basamak belirtme sembolunu console ekraninda virgul 
           //  olarak karsiliyoruz*/
           //  
           //  Console.WriteLine("***** Fiyat Listesi *****");
           //  Console.WriteLine();
           //  
           //  double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
           //  applePrice = 14.85;
           //  orangePrice = 20.95;
           //  strawberryPrice = 45;
           //  potatoPrice = 9.74;
           //  tomatoPrice = 6.88;
           //  Console.WriteLine("----- Elma Birim Fiyati:"+ applePrice+ "TL");
           //  Console.WriteLine("----- Portakal Birim Fiyati:"+ orangePrice+ "TL");
           //  Console.WriteLine("----- Cilek Birim Fiyati:"+strawberryPrice+ "TL");
           //  Console.WriteLine("----- Patates Birim Fiyati:"+potatoPrice+ "TL");
           //  Console.WriteLine("----- Domates Birim Fiyati:"+tomatoPrice+ "TL");
           //  
           //  Console.WriteLine();
           //  Console.WriteLine();
           //  double appleAmount, orangeAmount, strawberryAmount, potatoAmount , tomatoAmount;
           //  
           //  appleAmount = 1.245;
           //  orangeAmount = 2.650;
           //  strawberryAmount = 0.750;
           //  potatoAmount = 3.060;
           //  tomatoAmount = 4.090;
           //  
           //  double appleTotalPrice = appleAmount * applePrice;
           //  double orangeTotalPrice = orangeAmount * orangePrice;
           //  double strawberryTotalPrice = strawberryAmount * strawberryPrice;
           //  double  potatoTotalPrice = potatoAmount * potatoPrice;
           //  double tomatoTotalPrice = tomatoAmount * tomatoPrice;
           //  
           // // Console.WriteLine("Elmanin Toplam Fiyati:" +appleTotalPrice);
           // Console.WriteLine("Alinan Urun: Elma - "+ "Birim Fiyati:"+applePrice+ " - Gramaj:" + appleAmount + "Toplam Tutar:" + appleTotalPrice);
           // Console.WriteLine("Alinan Urun: Portakal - " + " Birim Fiyati:" + orangePrice + " - Gramaj:" + orangeAmount + "Toplam Tutar:" + orangeTotalPrice);
           // Console.WriteLine("Alinan urun: Cilek - " + " Birim Fiyati:" + strawberryPrice + " - Gramaj:" +strawberryAmount + "Toplam Tutar:" + strawberryTotalPrice);
           // Console.WriteLine("Alinan Urun: Patates - " + "Birim Fiyati:" + potatoPrice + " - Gramaj:" + potatoAmount + "Toplam Tutar:" + potatoTotalPrice);
           // Console.WriteLine("Alinan Urun: Domates - " + "Birim Fiyati:" + tomatoPrice + " - Gramaj:" +tomatoAmount+ "Toplam Tutar:" + tomatoTotalPrice);
           //
           // double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice +
           //                             tomatoTotalPrice;
           // Console.WriteLine();
           // Console.WriteLine();
           //  Console.WriteLine("Alisveris Toplam Tutari:" + shoppingTotalPrice+ "TL");
            
            #endregion
            
            #region Char DEGISKENLER
            
            // char degiskenler ' tek tirnak ile tanimlanir 
            char symbol;
            symbol = 'a';
            #endregion
            
            #region Klavyeden Veri Girisleri
            //hava yolu sirketi icin musterinin yolcu bilgilerini alicaz
            // Console.WriteLine();
            // Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi *****");
            // string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            
            
            // Console.Write("Yolcu Adi: ");
            // passengerName = Console.ReadLine(); /* yolcu adinin sagina ben bir deger gorucem ve enter tusuna basinca o 
            //  girmis oldugum degeri passenger name uzerine yazicak yani passenger name disaridan alinmis olucak*/
            // Console.Write("Yolcu Soyad: ");
            // passengerSurname = Console.ReadLine();
            /* Console.WriteLine("Yolcu:" +passengerName+ " " + passengerSurname);  yani once yazdigimiz bu kodla kendimiz klavyeden giricez 
            Console.Write("Yolcu Adi: ");
            passengerName = Console.ReadLine(); 
            Console.Write("Yolcu Soyad: ");
            passengerSurname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("----------------------------- "); ardindan  bu iki satirla da klavyeden girdigimiz verileri biza geri yazdiricak
            Console.WriteLine("Yolcu:" +passengerName+ " " + passengerSurname);*/
            
            // Console.Write("Ilce Bilgisi: ");
            // passengerDistrict = Console.ReadLine();
            // Console.WriteLine("Sehir Bilgisi:");
            // passengerCity = Console.ReadLine();
            // Console.WriteLine("Yolcu Yas:");
            // passengerAge = Console.ReadLine();
            // Console.WriteLine("Yolcu TC Kimlik No: ");
            // passengerIdentityNumber = Console.ReadLine();
            // Console.WriteLine();
            // Console.WriteLine("Yolcu TC Kimlik No:" +  passengerIdentityNumber + " - Yolcu Ad Soyad:"  + passengerName+ " " + passengerSurname+" "+ passengerDistrict+" / "+ passengerCity+"  "+ passengerAge);
            #endregion
            
            #region Klavyeden Tam Sayi Girisleri ve Donusumler

            /*integer islemlerde donusumler kullaniliyor.C# programlama dili console uzerinden girilen degerleri baslangicta string
             olarak kabul ediyor ve siz sayisal veya baska karakter veya true false degeri  seklinde deger giricekseniz  donusum uygulmamiz 
             gerekiyor. Bunun bana sayi oldugunu bildirmen gerekiyor diyor asilinda program */
            
            /*simdi bir eticaret icin satis paneli olusturalim urunler olsun urunlerden kac adet aldigimizi girelim ve para verelim bu
             paranin karsiligini alalim*/

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;
            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz:");
            shoesCount=int.Parse(Console.ReadLine());
            /*Parse donusturmek icin kullanilan bir metot ve parse diyor ki  ben sana integeri 32 bit formatinda donusturucem */
            Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz:");
            computerCount=int.Parse(Console.ReadLine());
            Console.Write("Lutfen lutfen aldiginiz sandalye sayisini giriniz:");
            chairCount=int.Parse(Console.ReadLine());
            Console.Write("Lutfen aldiginiz Televizyon sayisini giriniz:");
            tvCount=int.Parse(Console.ReadLine());
            
            int totalPrice = shoesCount * shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam odemeniz gereken tutan:" + totalPrice);
            #endregion

            #region Klavyeden Ondalikli Sayi Girisleri

            //klavyeden ogrencinin sinav notlarini giricez

            double exam1, exam2, exam3, result;
                Console.WriteLine("Lutfen ogrencinin 1.Sinav notunu giriniz");
                exam1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lutfen ogrencinin 2.Sinav notunu giriniz");
                exam2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Lutfen ogrencinin 3.Sinav notunu giriniz");
                exam3 = double.Parse(Console.ReadLine());
                result = (exam1 + exam2 + exam3) / 3;
                Console.WriteLine();
                Console.WriteLine(" Sinav ortalamaniz:"+result);
            #endregion
            
            #region Klavyeden Karakter Girisleri

            char gender;
            Console.Write("Lutfen cinsiyet seciniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Sectiginiz cinsiyet: "+ gender);
            #endregion

            
            
            
            
            Console.Read();
            
            
            
        }
    }
}