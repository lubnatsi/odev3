/*
soru1
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList sayilar = new ArrayList() { 5, 10, 15, 20, 25 };
        int toplam = 0;

        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
            toplam += sayi;
        }

        Console.WriteLine("Toplam: " + toplam);
    }
}







soru2
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(' ');

        Console.WriteLine("Kelime sayısı: " + kelimeler.Length);
    }
}




soru3
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList isimler = new ArrayList();
        
        Console.WriteLine("5 adet isim giriniz:");
        for (int i = 0; i < 5; i++)
        {
            isimler.Add(Console.ReadLine());
        }

        isimler.Sort();

        Console.WriteLine("Alfabetik sıralama:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}




soru4

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        int a = 0, b = 1;
        Console.Write(a + " " + b + " ");
        
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}




soru5

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int hedefSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele sayı
        int tahmin;
        
        Console.WriteLine("Bir sayı tahmin edin (1 ile 100 arasında):");
        
        while (true)
        {
            tahmin = int.Parse(Console.ReadLine());
            
            if (tahmin == hedefSayi)
            {
                Console.WriteLine("Tebrikler, doğru tahmin yaptınız!");
                break;
            }
            else if (tahmin < hedefSayi)
            {
                Console.WriteLine("Daha yüksek bir sayı girin:");
            }
            else
            {
                Console.WriteLine("Daha düşük bir sayı girin:");
            }
        }
    }
}


soru6
using System;

class Program
{
    static void Main()
    {
        string islem;
        double sayi1, sayi2;
        
        do
        {
            Console.WriteLine("Bir işlem girin (+, -, *, /) veya 'çıkış' yazın:");
            islem = Console.ReadLine();
            
            if (islem.ToLower() == "çıkış")
            {
                break;
            }

            Console.WriteLine("Birinci sayıyı girin:");
            sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı girin:");
            sayi2 = double.Parse(Console.ReadLine());

            if (islem == "+")
            {
                Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            }
            else if (islem == "/")
            {
                if (sayi2 != 0)
                {
                    Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                }
                else
                {
                    Console.WriteLine("Hata! Sıfıra bölme hatası.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem.");
            }

        } while (islem.ToLower() != "çıkış");
    }
}

soru7
using System;

class Program
{
    static void Main()
    {
        int toplam = 0;
        int sayi;
        
        // While döngüsü ile sayı toplama
        Console.WriteLine("Pozitif tam sayılar girin. 0 girildiğinde işlem sonlanır.");
        while (true)
        {
            sayi = int.Parse(Console.ReadLine());
            
            if (sayi == 0)
            {
                break;
            }
            if (sayi > 0)
            {
                toplam += sayi;
            }
        }

        // For döngüsü ile yazdırma
        Console.WriteLine("Girilen sayılar:");
        for (int i = 1; i <= toplam; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine("\nToplam: " + toplam);
    }
}




 */