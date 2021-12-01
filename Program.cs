using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaglarProgramlama
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, name2;
            Console.Write("Lütfen Birsoru numarası giriniz = ");
            name = Convert.ToString(Console.ReadLine());
            name2 = name.ToLower();
            switch (name2)
            {
                case "1":
                    int sayi1, sayi2, ort;
                    Console.WriteLine("Birinci sayıyı giriniz");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sayıyı giriniz");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    ort = (sayi1 + sayi2) / 2;
                    Console.WriteLine("İki sayının ortalaması:" + ort);
                    Console.ReadLine();
                    break;
                case "2":
                    int sayi;
                    Console.Write("Sayıyı Girin: ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Negatif");
                    }
                    else if (sayi > 0)
                    {
                        Console.WriteLine("Pozitif");
                    }
                    else
                    {
                        Console.WriteLine("Sayı Sıfır");
                    }
                    break;
                case "3":
                    int taban, yukseklik, alan;

                    Console.WriteLine("Lütfen üçgenin tabanını giriniz.");
                    taban = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz.");
                    yukseklik = Int32.Parse(Console.ReadLine());

                    alan = (taban * yukseklik) / 2;

                    Console.WriteLine("Üçgenin alanı={0}", alan);
                    Console.ReadLine();
                    break;
                case "4":
                    int x, y;
                    Console.WriteLine("1.sayıyı gir");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2.Sayıyı Gir:");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (x < y)
                        Console.WriteLine(x);
                    else
                        Console.WriteLine(y);
                    
                    break;
                case "5":
                    int vize, final, orta;
                    Console.Write("Vize notunu giriniz: ");
                    vize = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Final notunu giriniz: ");
                    final = Convert.ToInt32(Console.ReadLine());
                    orta = Convert.ToInt32(vize * 0.3 + final * 0.7);
                    Console.WriteLine();
                    Console.WriteLine("Ortalamanız = {0}", orta);
                    Console.WriteLine();    
                    break;

                case "6":
                    Console.Write("Yarıçapı Giriniz : ");
                    double yaricap = int.Parse(Console.ReadLine());

                    double dalan = Math.PI * yaricap * yaricap;
                    double cevre = 2 * Math.PI * yaricap;

                    Console.WriteLine("Alan : {0}", dalan);
                    Console.WriteLine("Çevre : {0}", cevre);
                    break;

                case "7":
                    int sayac = 0;
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 10; i++)
                    {
                        if (sayi > 50)
                        {
                            sayac = sayac + 1;
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {   
                            Console.Write("Sayı giriniz ---> ");
                            sayi = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("50'den Büyük Sayılar : " + sayac);
                    break;

                case "8":
                    int sayii, adet = 0;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.Write(i + ".sayıyı Girin : ");
                        sayii = Int32.Parse(Console.ReadLine());
                        if (sayii > 100)
                        {
                            adet++;
                        }
                    }
                    Console.WriteLine("100 den büyük girilen sayı adeti : " + adet);
                    break;

                case "9":
                    int sıfır, toplam = 0;
                    while (true)
                    {
                        Console.Write("Sayı Gir : ");
                        sıfır = Convert.ToInt32(Console.ReadLine());
                        if (sıfır == 0)
                        {
                            break;
                        }
                        toplam += sıfır;
                    }
                    Console.WriteLine("Girdiğiniz Sayıların Toplamı: " + toplam);
                    break;
                case "10":
                    int say1, say2, say3, nottop, nort;
                    Console.Write("1.Not=");
                    say1 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("2.Not=");
                    say2 = Convert.ToInt16(Console.ReadLine());
                    Console.Write("3.Not="); say3 = Convert.ToInt16(Console.ReadLine());
                    nottop = say1 + say2 + say3;
                    Console.WriteLine("TOPLAM=" + nottop);
                    nort = nottop / 3;
                    Console.WriteLine("ORTALAMA=" + nort);
                    break;
                case "11":
                    int ix = 1;
                    while (ix <= 1000)
                    {
                        Console.Write("{0}-", ix);
                        ix++;
                    }
                    break;
                case "12":
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi >= 0 && sayi <= 100)
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasındadır.");
                    else
                        Console.WriteLine("Girdiğiniz sayı '0' ve '100' arasında değildir.");
                    break;
                case "13":
                    int itoplam = 0,n;
                    Console.WriteLine("bir sayı giriniz");
                    n = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        itoplam += i;
                    }
                    Console.WriteLine("1 den Girdiğiniz sayıya kadar sayıların toplamı : " + itoplam);
                    break;
                case "14":
                    int not1, not2, not3, notort;
                    Console.WriteLine("Birinci sınav notunu giriniz:");
                    not1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("İkinci sınav notunu giriniz:");
                    not2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Üçüncü sınav notunu giriniz:");
                    not3 = Convert.ToInt32(Console.ReadLine());

                    notort = (not1 + not2 + not3) / 3;
                    Console.WriteLine("ÜÇ SINAVIN ORTALAMASI:"+notort);
                    break;
                case "15":
                    int d, r, g;
                    double pi = 3.14;

                    Console.WriteLine("Açıyı giriniz = ");
                    d = Convert.ToInt32(Console.ReadLine());

                    r = Convert.ToInt32(d * pi / 180);
                    g = d * 200 / 180;

                    Console.WriteLine("Radyan = " + r);
                    Console.WriteLine("Grad = " + g);
                    break;
                case "16":
                    int c;
                    Console.Write("Bir sayı giriniz: ");
                    c = Convert.ToInt16(Console.ReadLine());

                    if (c % 2 == 0) 
                    {
                        Console.Write(c + " sayisi çift sayıdır.");
                    }
                    else  
                    {
                        Console.Write(c + " sayisi tek sayıdır.");
                    }
                    break;
                case "17":
                    int m;
                    Console.Write("Bir sayı giriniz:");
                    int.TryParse(Console.ReadLine(), out m);
                    int mutlak = Math.Abs(m);
                    Console.WriteLine("Girilen sayının mutlak değeri:" + mutlak);
                    break;
                case "18":
                    Console.Write("1. Sayıyı giriniz ---> ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("2. Sayıyı giriniz ---> ");
                    sayi2 = Convert.ToInt32(Console.ReadLine());
                    if (sayi1 % sayi2 == 0)
                        Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısana tam bölünür.");
                    else
                        Console.WriteLine("Girdiğiniz " + sayi1 + " sayısı " + sayi2 + " sayısana tam bölünmez.");
                    break;
                case "19":

                    toplam = 0;
                    Console.Write("Sayı giriniz ---> ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i <= sayi; i++)
                    {
                        if (i % 2 == 0)
                            toplam = toplam + i;
                    }
                    Console.WriteLine(sayi + " sayısına kadar çift sayıların toplamı: " + toplam);
                    break;
                case "20":
                    int kök;
                    Console.Write("A değeri giriniz");
                    int AA = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B değeri giriniz");
                    int BB = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C değeri giriniz");
                    int CC = Convert.ToInt32(Console.ReadLine());
                    kök = (CC - BB) / AA;
                    Console.WriteLine("Kök = " + kök);
                    break;
                case "21":
                    Console.Write("A değeri giriniz");
                    int A = Convert.ToInt32(Console.ReadLine());
                    Console.Write("B değeri giriniz");
                    int B = Convert.ToInt32(Console.ReadLine());
                    Console.Write("C değeri giriniz");
                    int C = Convert.ToInt32(Console.ReadLine());
                    double z = (B * B) - (4 * A * C);
                    if (z > 0)
                    {
                        double x1 = ((-B - Math.Sqrt(z)) / (2 * A));
                        double x2 = ((-B + Math.Sqrt(z)) / (2 * A));
                        Console.WriteLine("Denklemin iki kökü vardır = ");
                        Console.WriteLine("x1 = " + x1);
                        Console.WriteLine("x2 = " + x2);
                    }
                        break;
                case "22":
                    double boy, kilo, indeks;
                    Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1,65) --->  ");
                    boy = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Kilonuzu Giriniz --->  ");
                    kilo = Convert.ToDouble(Console.ReadLine());
                    indeks = kilo / (boy * boy);
                    Console.WriteLine("Vücut Kitle İndeksiniz : " + indeks);
                    if (indeks < 18.5)
                        Console.WriteLine("Zayıf");
                    else if (indeks >= 18.5 && indeks < 24.9)
                        Console.WriteLine("Normal");
                    else if (indeks >= 25 && indeks < 29.9)
                        Console.WriteLine("Fazla Kilolu");
                    else if (indeks <= 30 && indeks < 34.9)
                        Console.WriteLine("I. Derece Obez");
                    else if (indeks <= 35 && indeks < 39.9)
                        Console.WriteLine("II. Derece Obez");
                    else
                        Console.WriteLine("III. Derece Obez");
                    break;
                    break;
                case "23":
                    double Scalis, Sucret, Ucret;
                    Console.Write("Kaç saat çalıştığınızı yazınız --->  ");
                    Scalis = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Saat ücreti giriniz --->  ");
                    Sucret = Convert.ToDouble(Console.ReadLine());
                    if (Scalis < 40)
                    {
                        Ucret = Scalis * Sucret;
                    }
                    else
                    {
                        Ucret = (Scalis * 2) * Sucret;
                    }
                    Console.Write("Alacağınız ücret : " + Ucret + " TL ");
                    break;
                case "24":
                    Console.Write("Sayı giriniz --->  ");
                    sayi = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Girdiğiniz sayının tam bölenleri : ");
                    for (int i = 1; i <= sayi; i++)
                    {
                        if (sayi % i == 0)
                            Console.Write(i + " - ");
                    }
                    break;
                case "25":
                    int afaktoriyel=1;
                    Console.Write("Faktröriyelinin bulunmasını istediğiniz bir sayı giriniz --->  ");
                    sayi1 = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= sayi1; i++)
                        afaktoriyel = afaktoriyel * i;
                    Console.WriteLine(sayi1 + "! = " + afaktoriyel);
                    break;

                default:
                    Console.Write("Böyle Dir Soru Yoktur!");
                    break;
            }

            Console.ReadKey();
        }

        
        }
    }

