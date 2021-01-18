using System;

namespace Şifre_Oluşturucu
{
    class SifreOlusturucu
    {
        static void Main(string[] args)
        {
            String[] harfler = {"Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","İ","Z","X","C","V","B","N","M"};
            String[] sayilar = {"0","1","2","3","4","5","6","7","8","9"};
            String[] ozelKarekter = {"!","#","$","%","&","'","(",")","*","+",",","-",".","/",":",";","<","=",">","?","@","[","]","^","_","`","{","|","}","~"};
            String tip,sifre,sayi3,harf3,ozel3;
            int uzunluk;
            String sayi2,harf2,ozel2;
            Random random = new Random();
            Random randomSayi = new Random();
            Random randomHarf = new Random();
            Random randomOzel = new Random();
            Boolean harf,sayi,ozel;
            System.Console.WriteLine("Şifre Oluşturucuya Hoşgeldin.");
            System.Console.WriteLine("Öncelikle Şifreni Kaç Haneden Oluşturmak İstersin?");
            uzunluk = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Şifren {0} Haneden Oluşacak.",uzunluk);
            System.Console.WriteLine("Şimdi Şifrende Hangi Karakterler Bulunacak Onları Seç.");

            harf:
            System.Console.WriteLine("Şifrende Harfler Olsun Mu? 'E'-'H'");
            tip = Console.ReadLine();
            if (tip.Equals("E") || tip.Equals("e")) {
                harf = true;
            }else if (tip.Equals("H") || tip.Equals("h")) {
                harf = false;
            }else {
                System.Console.WriteLine("Lütfen Geçerli Bir Harf Gir.");
                goto harf;
            }
            sayi:
            System.Console.WriteLine("Şifrende Sayılar Olsun Mu? 'E'-'H'");
            tip = Console.ReadLine();
            if (tip.Equals("E") || tip.Equals("e")) {
                sayi = true;
            }else if (tip.Equals("H") || tip.Equals("h")) {
                sayi = false;
            }else {
                System.Console.WriteLine("Lütfen Geçerli Bir Harf Gir.");
                goto sayi;
            }
            ozel:
            System.Console.WriteLine("Şifrende Özel Karakterler Olsun Mu? 'E'-'H'");
            tip = Console.ReadLine();
            if (tip.Equals("E") || tip.Equals("e")) {
                ozel = true;
            }else if (tip.Equals("H") || tip.Equals("h")) {
                ozel = false;
            }else {
                System.Console.WriteLine("Lütfen Geçerli Bir Harf Gir.");
                goto ozel;
            }
            sifre = "";
            sayi3 = "";
            harf3 = "";
            ozel3 = "";

            for (int i = 0; i < uzunluk; i++)
            {
                if (sayi == true) {
                    sayi2 = Convert.ToString(randomSayi.Next(0,9));
                    sayi3 = sayilar[Convert.ToInt32(sayi2)];
                }else {
                    sayi2 = "";
                }
                if (harf == true) {
                    harf2 = Convert.ToString(randomHarf.Next(0,26));
                    switch (random.Next(1,3))
                    {
                        case 1: 
                        {
                            harf3 = harfler[Convert.ToInt32(harf2)].ToLower();
                            break;
                        }
                        case 2:
                        {
                            harf3 = harfler[Convert.ToInt32(harf2)];
                            break;
                        }
                        default:
                            harf3 = harfler[Convert.ToInt32(harf2)];
                            break;
                    }
                }else {
                    harf2 = "";
                }
                if (ozel == true) {
                    ozel2 = Convert.ToString(randomHarf.Next(0,29));
                    ozel3 = ozelKarekter[Convert.ToInt32(ozel2)];
                }else {
                    ozel2 = "";
                }
                switch (random.Next(1,3))
                {
                    case 1:
                    {
                        if (ozel == true) {
                        sifre = sifre+ozel3;
                        }else {
                            i = i -1;
                        }
                        break;
                    }
                    case 2:
                    {
                        if (harf == true) {
                        sifre = sifre+harf3;
                        }else {
                            i = i -1;
                        }
                        break;
                    }
                    case 3:
                    {
                        if (sayi == true) {
                        sifre = sifre+sayi3;
                        }else {
                            i = i -1;
                        }
                        break;
                    }
                    default:
                        break;
                }
            }
            if (sifre.Contains("ı")) {
                sifre.Replace('ı','I');
            }
            if (sifre.Contains("İ")) {
                sifre.Replace('İ','i');
            }
            System.Console.WriteLine("Şifreniz Başarılı Bir Şekilde Oluşturuldu.");
            System.Console.WriteLine("Şifren: " + sifre);

        }
    }
}