namespace FileOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klasor Oluşturma
            //string klasoradi = @"c:\denemeklasoru";
            //System.IO.Directory.CreateDirectory(klasoradi);

            #endregion

            #region Alt Klasor Olusturma


            //string klasoradi = @"c:\denemeprogramlama";
            //System.IO.Directory.CreateDirectory(klasoradi);
            //string altklasoradi = System.IO.Path.Combine(klasoradi, "C# Alt Klasor");
            //System.IO.Directory.CreateDirectory(altklasoradi);

            #endregion


            #region Varolan Klasörün İç Klasörünü Sorgulayıp İçine Klasör Oluşturma
            //Console.Write("Öğrenci no girin: ");
            //string ogrNo = Console.ReadLine();

            //Console.Write("Kayıt Olunacak sınıfı giriniz: ");
            //string sinif = Console.ReadLine();

            //string klasoryolu = @"c:\okul\" + sinif;
            //if (System.IO.Directory.Exists(klasoryolu) == true)
            //{
            //    string ogrenciklasorhedefyolu = @"c:\okul\" + sinif + "\\" + ogrNo;
            //    System.IO.Directory.CreateDirectory (ogrenciklasorhedefyolu);
            //    Console.Write("{0} numaralı öğrenci için klasör oluşturuldu.", ogrNo);

            //}
            //Console.ReadLine();
            #endregion

            #region Klasor Silme
            //string klasor_yolu = @"c:\notlarım";
            //if (System.IO.Directory.Exists(klasor_yolu))
            //    {

            //    System.IO.Directory.Delete(klasor_yolu,true);

            #endregion


            #region TXT Oluşturma

            //string dosya_adi = "deneme.txt";
            //string dosya_yolu = @"c:\deneme";
            //string hedef_yolu = System.IO.Path.Combine(dosya_yolu, dosya_adi);

            //if (System.IO.File.Exists(hedef_yolu))
            //{
            //    Console.WriteLine("Dosya Mevcut");

            //}
            //else
            //{
            //    System.IO.File.Create(hedef_yolu);
            //}

            //Console.ReadLine();
            #endregion



            #region TXT Doyasına Veri Ekleme

            // 1. YÖNTEM DİZİ ELEMANLARINI SATIR SATIR TXT DOSYASINA YAZDIRMA
            //string[] satirlar = { "Adı: Kaan" , "Soyadı: Aydan" , "Yaş: 28" };
            //System.IO.File.WriteAllLines(@"c:\deneme\deneme.txt",satirlar);


            // 2.YÖNTEM STRING BİR DEĞİŞKENİ TXT DOSYASINA YAZDIRMA
            //string ozgecmis = "2019 yılında Bahçeşehir Üniversitesinden mezun olmuştur.Ardından iş hayatına başlamıştır.";
            //System.IO.File.WriteAllText(@"c:\deneme\deneme2.txt",ozgecmis);

            // 3.YÖNTEM BİR DİZİDEKİ YALNIZCA İSTENİLEN ELEMANLARI TXT DOSYASINA YAZDIRMA
            //string[] personel = { "personel : Kaan", "personel : melis", "müdür : Zeki ", "müdür : Hayrike" };
            //using(System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\kaan.aydan\Desktop\deneme1\deneme1.txt"))
            //{
            //    foreach(string item in personel) 
            //    {
            //        if (item.Contains("müdür"))
            //        {
            //            dosya.WriteLine(item);
            //        }
            //    }
            //}

            //4. YÖNTEM VAR OLAN BİR TEXT DOSYASINA METİN EKLEME
            //NOT: ilk yöntemlerde varolan dosya içerisine yazıldığında dosya içindeki veriler silinmekteydi ancaj bu yöntemde üzerine eklemekte.

            //using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\kaan.aydan\Desktop\deneme1\deneme1.txt", true))
            //    dosya.WriteLine("EKLENCEK SATIRLARKE");
            #endregion




        }
    }

}