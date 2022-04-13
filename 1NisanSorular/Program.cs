
1)

using System;

namespace quiz

{
    class algorithm
    {
        static void Main(string[] args)
        {
            //Ekrana 10 kez “Hello World!” yazdır.

            for (int i = 0; i < 10; i++)


            {
                Console.WriteLine("{0} HelloWorld", i);
                Console.ReadLine();
            }

        }

    }

}

2)

using System;

namespace quiz

{
    class algorithm
    {
        static void Main(string[] args)
        {
            //Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdır. Örneğin 11 girdiyse ekrana “2”,”4”,”6”,”8” gibi.
            Console.WriteLine("lütfen bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.Readline());

            for (int i = 0; i <= sayi; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("cift sayilar", i);
                    Console.ReadKey();
                }
            }

        }

    }

4)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {
                //Dışarıdan girilen sayıya kadar olan çift sayıları ekrana yazdır. Örneğin 11 girdiyse ekrana “2”,”4”,”6”,”8” gibi.
                Console.WriteLine("lütfen bir para giriniz");
                int i = Convert.ToInt32(Console.Readline());
                int kdvli_fiyat;

                {
                    if (int i >= 0)
                {
                        Console.WriteLine("sayi pozitif", i);
                        Console.ReadKey();

                        kdvli_fiyat = i + i * (18 / 100);
                        Console.WriteLine("kdv li fiyat", kdvli_fiyat);
                        Console.ReadKey();
                    }
                else
                        Console.WriteLine("sayi negatif", i);
                    Console.ReadKey();
                }

            }

        }

    }

5)
using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {

                int vize, final, ortalama;
                Console.Write("Vize notunu giriniz: ");
                vize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Final notunu giriniz: ");
                final = Convert.ToInt32(Console.ReadLine());
                ortalama = vize * (30 / 100) + final * (70 / 100);
                Console.WriteLine("notunuz", ortalama);
                Console.ReadLine();


            }

        }

    }


6)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {

                int sayi;
                Console.WriteLine("bir sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi % 2 == 0)

                {
                    Console.WriteLine("cift bu aslan", sayi);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("tek bu aslan", sayi);
                    Console.ReadKey();

                }


            }

        }

    }

7)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {

                int yükseklik, taban, alan;
                Console.WriteLine("bir yükseklik giriniz");
                yükseklik = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bir taban giriniz");
                taban = Convert.ToInt32(Console.ReadLine());
                alan = taban * yükseklik / 2;
                Console.WriteLine("alan :", alan);
                Console.ReadLine();


            }

        }

    }

8)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {

                int x, y;
                Console.WriteLine("bir x giriniz");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("bir y giriniz");
                y = Convert.ToInt32(Console.ReadLine());

                if (x % y == 0)
                {
                    Console.WriteLine("sayilar bölünebilir");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("sayilar bölünemez");
                    Console.ReadLine();
                }
            }

        }

    }

9)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {

                int x, beskati = 0;
                Console.WriteLine("bir x giriniz");
                x = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i <= 5; i++)


                {
                    beskati = beskati + x;
                }

                Console.WriteLine("sonuc", beskati);
                Console.ReadKey();

            }

        }

    }
        
    

10)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {


                Console.Write("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                int sayac = 0;

                for (int i = 0; i < sayi; i++)

                {
                    sayi = sayi / 10;
                    sayac++;

                }

                Console.WriteLine("basamak sayısı", sayac);
                Console.ReadLine();


            }
        }

    }

11)

using System;

namespace quiz

    {
        class algorithm
        {
            static void Main(string[] args)
            {


                Console.Write("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                int sayac = 0;

                for (int i = 2; i < sayi; i++)
                {
                    sayac = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            sayac++;
                        }
                    }
                    if (sayac == 0)
                    {
                        Console.WriteLine("Asal Sayılar = " + i);
                        Console.ReadLine();
                    }
                }


            }
        }
    }

        
12)


