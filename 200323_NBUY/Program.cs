using System;
using System.Collections;
using System.Xml;

namespace _200323_NBUY
{
    class Program
    {
        static void Main(string[] args)
        {
        #region otopark arraylist ile araç kaydetme ve yazdırma
        /*   ArrayList otopark = new ArrayList(20);

           for (int i = 0; i < 20; i++)
           {
               otopark.Add(null);
           }

           while (true)
           {
               Console.WriteLine("Lütfen araç plakasını girin:");
               string plaka = Console.ReadLine();

               Console.WriteLine("Hangi park yerine park yapılsın (1-20)");
               int parkYeri = int.Parse(Console.ReadLine()) - 1;

               if (otopark[parkYeri] == null)
               {
                   otopark[parkYeri] = plaka;
                   Console.WriteLine("Araç park edildi.");
               }
               else
               {
                   Console.WriteLine("Bu park yeri dolu.");
               }

               Console.WriteLine("Güncel otopark durumu:");
               for (int i = 0; i < 20; i++)
               {
                   if (otopark[i] == null)
                   {
                       Console.WriteLine("Park Yeri " + (i + 1) + " : BOŞ");
                   }
                   else
                   {
                       Console.WriteLine("Park Yeri " + (i + 1) + " : " + otopark[i]);
                   }
               }
           } */
        #endregion

        #region abstract metodlar
        /* Keman keman = new Keman();
         keman.Cal();
         keman.Sarkı();

     }


     abstract class MuzikAletleri
     {
         public abstract void Cal();
         public abstract void Sarkı();
         // abstract sınıflar sadece miras almak ıcın tasarlanan sınıflardır
         // abstract sınıflarda herhangi bir eleman abstract olabilir
         //abstract metod yada property haricinde abstract olmayan metod property olabilir.
     }
     class Gitar : MuzikAletleri
     {
         public override void Cal()
         {
             Console.WriteLine("DINDINDDIN");
         }

         public override void Sarkı()
         {
             Console.WriteLine("Desperado");
         }
     }
     class Keman : MuzikAletleri
     {
         public override void Cal()
         {
             Console.WriteLine("GIYGIYIGIYIGIY");
         }

         public override void Sarkı()
         {
             Console.WriteLine("Hungarian");
         }
     }
     class Flut : MuzikAletleri
     {
         public override void Cal()
         {
             Console.WriteLine("DÜTÜTÜDÜT");
         }

         public override void Sarkı()
         {
             Console.WriteLine("bak postacı geliyor");
         } */
        #endregion

        #region hayvanlar abstract
        /*    kopek k1 = new kopek();
            Console.WriteLine("KOPEK");
            k1.ses();
            k1.hareket();
            Console.WriteLine();
            yarasa y1 = new yarasa();
            Console.WriteLine("yarasa");
            y1.ses();
            y1.hareket();
            Console.WriteLine();
            kedi k11 = new kedi();
            Console.WriteLine("Kedi");
            k11.ses();
            k11.hareket();
        }
    }
    abstract class canli
    {
        public abstract void ses();
        public abstract void hareket();
    }
    class kopek : canli
    {
        public override void hareket()
        {
            Console.WriteLine("YAPTIGI IS KOŞMAK");
        }

        public override void ses()
        {
            Console.WriteLine("CIKARDIGI SES HAWHAW");
        }
    }
    class kedi : canli
    {
        public override void hareket()
        {
            Console.WriteLine("YAPTIGI IS KAÇMAK");
        }

        public override void ses()
        {
            Console.WriteLine("CIKARDIGI SES MİAWW");
        }
    }
    class fare : canli
    {
        public override void hareket()
        {
            Console.WriteLine("YAPTIGI IS KEMİRME");
        }

        public override void ses()
        {
            Console.WriteLine("CIKARDIGI SES VİKVİK");
        }
    }
    class yarasa : canli
    {
        public override void hareket()
        {
            Console.WriteLine("YAPTIGI IS UCMAK");
        }

        public override void ses()
        {
            Console.WriteLine("CIKARDIGI SES VIYYK");
        } */
        #endregion

        #region abstract metot ve degısken
        /*  abstract class hayvan
          {
              protected string Renk;
              abstract public void ses();
              public abstract int ayaksayisi { get; set; }
          }
          class kopek : hayvan
          {
              public override int ayaksayisi { get; set; }

              public override void ses()
              {
                  Console.WriteLine("havhav");
              }
          }
          class kırkayak : hayvan
          {
              public override int ayaksayisi { get; set; }

              public override void ses()
              {
                  Console.WriteLine("zzzzzzzzhhhhzzzhhh");
              }
          } */
        #endregion

        #region Abstract metot ile kullanıcı girişi yazdırma
        /*      spor s1 = new spor();
              Console.WriteLine("Numara Gir");
              s1.no = int.Parse(Console.ReadLine());
              s1.yaz();


          }
      }
      abstract class ayakkabi
      {
          public int no { get; set; }
          public string renk { get; set; }
          public abstract string tür { get; set; }
          abstract public void yaz();

      }
      class spor : ayakkabi
      {
          public override string tür { get; set; }

          public override void yaz()
          {
              Console.WriteLine("Spor Ayakkabı Numaranız: " + no);
          }
      }
      class gece : ayakkabi
      {
          public override string tür { get; set; }

          public override void yaz()
          {
              throw new NotImplementedException();
          } */
        #endregion

        #region AyakkabıUretme
        /*    class AyakkabiFabrikasi
           {
               public int AyakkabiNum { get; set; }
               public string AyakkabiRenk { get; set; }
               public int Fiyat { get; set; }
               public Boolean Bagcik { get; set; }
               public string AyakkabiTürü { get; set; }

               virtual public void Ozellikler()
               {

               }
           }
           class Bot : AyakkabiFabrikasi
           {
               public override void Ozellikler()
               {
                   string bagcik = (Bagcik == true) ? "var" : "yok";
                   Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\nBağcık: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);

               }
           }
           class Sandalet : AyakkabiFabrikasi
           {
               public override void Ozellikler()
               {
                   string bagcik = (Bagcik == true) ? "var" : "yok";
                   Console.Write("Ayakkabı türü: {0}\nSandalet Numarası: {1}\nSandalet Rengi: {2}\nSandalet Fiyatı: {3}TL\nBağcık: {4} \n", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
               }
           }
           class SporAyakkabi : AyakkabiFabrikasi
           {
               public override void Ozellikler()
               {

               }
           }
           class Kosu : SporAyakkabi
           {
               public override void Ozellikler()
               {
                   string bagcik = (Bagcik == true) ? "var" : "yok";
                   Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\n Bağcık: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
               }
           }
           class Futbol : SporAyakkabi
           {
               public override void Ozellikler()
               {
                   string bagcik = (Bagcik == true) ? "var" : "yok";
                   Console.Write("Ayakkabı türü: {0}\nAyakkabi Numarası: {1}\nAyakkabı Rengi: {2}\nAyakkabının Fiyatı: {3}TL\n Bağcık: {4}", AyakkabiTürü, AyakkabiNum, AyakkabiRenk, Fiyat, bagcik);
               }
           }
           static void Main(string[] args)
           {
               try
               {
                   Kosu Run = new Kosu();
                   Futbol Foot = new Futbol();
                   Bot Bot = new Bot();
                   Sandalet Terlik = new Sandalet();
               bidaha:
                   Console.Clear();
                   Console.WriteLine("**********Hoşgeldiniz**********\n\n\tAyakkabıTürü Seçiniz\n\t1-Bot\n\t2-Koşu\n\t3-Futbol\n\t4-Sandalet");
                   byte Secim = byte.Parse(Console.ReadLine());
                   if (Secim < 1 || Secim > 4)
                   {
                       Console.WriteLine("Geçersiz Bir Seçim\nProgram Tekrar Başlatılıyor.");
                       System.Threading.Thread.Sleep(2000);
                       goto bidaha;
                   }
                   Console.WriteLine("Ayakkabı Rengini Giriniz(Mavi,Yeşil,Siyah...)");
                   string Renk = Console.ReadLine();

                   Console.WriteLine("Bağcık var mı? (true/false)");
                   Boolean Bagcik = Boolean.Parse(Console.ReadLine());

               tekrar:
                   Console.WriteLine("Ayakkabı Numarası Seçiniz(1/47)");
                   byte Numara = byte.Parse(Console.ReadLine());

                   switch (Secim)
                   {
                       case 1:
                           #region Bot
                           Bot.AyakkabiTürü = "Bot";
                           Bot.AyakkabiNum = Numara;
                           Bot.AyakkabiRenk = Renk;
                           Bot.Bagcik = Bagcik;
                           if (Numara < 30 && Numara > 18)
                           {
                               Bot.Fiyat = 79;
                           }
                           else if (Numara >= 30 && Numara < 40)
                           {
                               Bot.Fiyat = 89;
                           }
                           else if (Numara >= 40 && Numara <= 47)
                           {
                               Bot.Fiyat = 109;
                           }
                           else
                           {
                               Console.WriteLine("Geçersiz bir numara");
                               goto tekrar;
                           }
                           Bot.Ozellikler();
                           break;
                       #endregion
                       case 2:
                           #region Koşu Ayakkabısı
                           Run.AyakkabiTürü = "Koşu Ayakkabısı";
                           Run.AyakkabiNum = Numara;
                           Run.AyakkabiRenk = Renk;
                           Run.Bagcik = Bagcik;
                           if (Numara < 30 && Numara > 0)
                           {
                               Run.Fiyat = 129;
                           }
                           else if (Numara >= 30 && Numara < 40)
                           {
                               Run.Fiyat = 139;
                           }
                           else if (Numara >= 40 && Numara <= 47)
                           {
                               Run.Fiyat = 159;
                           }
                           else
                           {
                               Console.WriteLine("Geçersiz bir numara");
                               goto tekrar;
                           }
                           Run.Ozellikler();
                           break;
                       #endregion
                       case 3:
                           #region Futbol Ayakkabısı
                           Foot.AyakkabiTürü = "Futbol Ayakkabısı";
                           Foot.AyakkabiNum = Numara;
                           Foot.AyakkabiRenk = Renk;
                           Foot.Bagcik = Bagcik;
                           if (Numara < 30 && Numara > 0)
                           {
                               Foot.Fiyat = 170;
                           }
                           else if (Numara >= 30 && Numara < 40)
                           {
                               Foot.Fiyat = 185;
                           }
                           else if (Numara >= 40 && Numara <= 47)
                           {
                               Foot.Fiyat = 199;
                           }
                           else
                           {
                               Console.WriteLine("Geçersiz bir numara");
                               goto tekrar;
                           }
                           Foot.Ozellikler();
                           break;
                       #endregion
                       case 4:
                           #region Terlik
                           Terlik.AyakkabiTürü = "Sandalet";
                           Terlik.AyakkabiNum = Numara;
                           Terlik.AyakkabiRenk = Renk;
                           Terlik.Bagcik = Bagcik;
                           if (Numara < 30 && Numara > 0)
                           {
                               Terlik.Fiyat = 29;
                           }
                           else if (Numara >= 30 && Numara < 40)
                           {
                               Terlik.Fiyat = 39;
                           }
                           else if (Numara >= 40 && Numara <= 47)
                           {
                               Terlik.Fiyat = 49;
                           }
                           else
                           {
                               Console.WriteLine("Geçersiz bir numara");
                               goto tekrar;
                           }
                           Terlik.Ozellikler();
                           break;
                       #endregion
                       default:
                           break;
                   }
               }
               catch (Exception abc)
               {
                   Console.WriteLine("Hata Türü: {0}", abc);

               } */
        #endregion

        #region Müdür,Memur,Güvenlik Abstract Metot İle Seçilen Görevliyi yazdırma
        go:
            Console.WriteLine("Çalışan seçin");
            Console.WriteLine("1-MÜDÜR \n2-MEMUR \n3-GÜVENLİK");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                mudur m1 = new mudur();
                m1.görev = "Müdür";
                m1.yapilanis = "Maas Ödeme";
                m1.yaz();
            }
            else if (secim == "2")
            {
                memur m2 = new memur();
                m2.görev = "Memur";
                m2.yapilanis = "Evrak İşleri";
                m2.yaz();
            }
            else if (secim == "3")
            {
                guvenlik g1 = new guvenlik();
                g1.görev = "Güvenlik";
                g1.yapilanis = "Giriş Kontrolü";
                g1.yaz();
            }
            else
            {
                Console.WriteLine("Hatalı Seçim.Tekrar Deneyin");
                goto go;
            }

        }
        abstract class calisan
        {
            public string görev { get; set; }
            public string yapilanis { get; set; }
            abstract public void yaz();
        }
        class mudur : calisan
        {
            public override void yaz()
            {
                Console.WriteLine("GÖREVİ: " + görev + " " + "Yaptığı İş: " + yapilanis);
            }
        }
        class memur : calisan
        {
            public override void yaz()
            {
                Console.WriteLine("GÖREVİ: " + görev + " " + "Yaptığı İş: " + yapilanis);
            }
        }
        class guvenlik : calisan
        {
            public override void yaz()
            {
                Console.WriteLine("GÖREVİ: " + görev + " " + "Yaptığı İş: " + yapilanis);
            }
        }
    }
} 
#endregion