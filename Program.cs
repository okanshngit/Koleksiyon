using System;
using System.Collections.Generic;

    namespace generic_list
    {
        class Program
        {
            
            static void Main(string[] args)
            {    

                //Bu dersimizde List sınıfını inceleyeceğiz:
                //List<T> class (syntax'ı)
                //System.Collections.Generic (namespace'i altından geliyor ve bu namespace altından gelmesi bize birçok kullanılabilir metot sunuyor)
                //T->generic olduğunu söylüyor,object türündedir.Lisetnin içerisindeki nesnelerin tipini ifade ediyor.Hangi tipten bir nesne ekliceksem bunu T ile belirtiyor olmamız gerekiyor.

                //Integer tipinde bir liste oluşturalım:
                List<int> sayiListesi=new List<int>();
                sayiListesi.Add(23);
                sayiListesi.Add(10);
                sayiListesi.Add(4);
                sayiListesi.Add(5);
                sayiListesi.Add(92);
                sayiListesi.Add(34);

                //String tipinde bir liste oluşturalım:
                List<string> renkListesi=new List<string>();
                renkListesi.Add("kırmızı");
                renkListesi.Add("mavi");
                renkListesi.Add("turuncu");
                renkListesi.Add("sarı");
                renkListesi.Add("yeşil");
             
                //Count //Count:sayı //Listedeki eleman sayısını öğreniriz.
                Console.WriteLine("*****Count*****");
                Console.WriteLine(sayiListesi.Count);
                Console.WriteLine(renkListesi.Count);



                //Foreach ve List.Foreach ile elemanlara erişim:
                Console.WriteLine("*****Foreach*****");
                foreach (var sayi in sayiListesi)// sayiListesi.ForEach(sayi=> Console.WriteLine(sayi))
                {
                    Console.WriteLine(sayi);
                }

                foreach (var renk in renkListesi)//renkListesi.ForEach(renk=> Console.WriteLine(renk))
                {
                    Console.WriteLine(renk);
                }
                
                Console.WriteLine("*****List.Foreach*****");
                sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));//List class'ının bize sunduğu foreach için ekstra bir metottur. (=>:öyleki)

                renkListesi.ForEach(renk=> Console.WriteLine(renk));//List class'ının bize sunduğu foreach için ekstra bir metottur. (=>:öyleki)

                //Listeden eleman çıkarma:
                Console.WriteLine("*****Remove*****");
                sayiListesi.Remove(4);//yazdığımız 4 elamanını listeden çıkartır.
                renkListesi.Remove("yeşil");//yazdığımız yeşil elemanının listeden çıkarır.

                Console.WriteLine("*****List.Foreach*****");
                sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
                renkListesi.ForEach(renk=> Console.WriteLine(renk));
                
                Console.WriteLine("*****RemoveAt*****");
                sayiListesi.RemoveAt(0);//sayiListesi listesinin 0. indexindeki elemanı çıkarır.
                renkListesi.RemoveAt(1);//renkListesi listesinin 1. indexindeki elemanı çıkarır.

                Console.WriteLine("*****List.Foreach*****");
                sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
                renkListesi.ForEach(renk=> Console.WriteLine(renk));

                //Liste içerisinde arama:
                Console.WriteLine("*****Contains*****");
                if(sayiListesi.Contains(10))
                {
                    Console.WriteLine("10 liste içerisinde bulundu!");
                }
                if(renkListesi.Contains("turuncu"))
                {
                    Console.WriteLine("turuncu liste içerisinde bulundu!");
                }

                //Eleman ile index'e erişme:
                 Console.WriteLine("*****BinarySearch*****");
                 Console.WriteLine(renkListesi.BinarySearch("sarı"));
                 Console.WriteLine(renkListesi.BinarySearch("kırmızı"));
                 Console.WriteLine(renkListesi.BinarySearch("turuncu"));

                //Diziyi List'e çevirme:
                string[] hayvanlar={"Kedi","Köpek","Kuş"};
                List<string> hayvanListesi = new List<string>(hayvanlar);

                //Listeyi nasıl temizleriz?
                hayvanListesi.Clear();

                //List içerisinde nesne tutmak
                List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

                Kullanıcılar kullanıcı1=new Kullanıcılar();
                kullanıcı1.Isim="Ayşe";
                kullanıcı1.Soyisim="Yılaz";
                kullanıcı1.Yas=26;

                Kullanıcılar kullanıcı2=new Kullanıcılar();
                kullanıcı2.Isim="Özcan";
                kullanıcı2.Soyisim="Çalışkan";
                kullanıcı2.Yas=26;

                kullanıcıListesi.Add(kullanıcı1);
                kullanıcıListesi.Add(kullanıcı2);

                List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

                yeniListe.Add(new Kullanıcılar (){
                    Isim ="Arda",
                    Soyisim="Deniz",
                    Yas=24
                });

                foreach (var kullanıcı in kullanıcıListesi)
                {
                    Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                    Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                    Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
                    
                }

                  foreach (var kullanıcı in yeniListe)
                {
                    Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                    Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                    Console.WriteLine("Kullanıcı Yaşı:" + kullanıcı.Yas);
                    
                }

            }
        }

        public class Kullanıcılar
        {
            private string isim;
            private string soyisim;
            private int yas;


            public string Isim{get=>isim;set=>isim=value;}
            public string Soyisim{get=>soyisim;set=>soyisim=value;}
            public int Yas{get=>yas;set=>yas=value;}


        }    
    }