using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._03._20_ahmet
{
    class Program
    //Classlar heap bölgesinde durarak birden fazla field(alan) oluşturmamızı sağlıyor.
    //Mutlak değer 'evim.odasayisi = Math.Abs(değer);' şeklinde yazılıyor ve - değer + olarak çıkıyor
    //Fieldları public olarak atamamak için kapsülleme yapıyoruz.

    {
        static void Main(string[] args)
        {



            //Console.WriteLine("Oda Sayısı:" + evim.OdaSayisiBilgi());
            //Console.WriteLine(evim.Evbilgileri());


            //Personel a = new Personel();

            //Console.WriteLine("Taban Aylığınızı Giriniz:");
            //a.TabanAylikAta(double.Parse(Console.ReadLine()));

            //Console.WriteLine("Çalışma Yılınızı Giriniz:");
            //a.CalismaYilAta(byte.Parse(Console.ReadLine()));

            //Console.WriteLine(a.PersonelBilgi());


            Ev evim = new Ev();
            evim.katno = 4;
            evim.Odasayisi = -3;
            Console.WriteLine(evim.Evbilgileri());


            //Deneme.txt isminde içinde deneme yazan txt belgesi oluşturduk.
            //FileStrem yazdıktan sonra ctrl+. ile en üsttekini seçiyoruz.
            FileStream fs = new FileStream(@"D:\deeeneme.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Deneme");
            fs.Flush();//Rami temizliyor
            sw.Close();//Temizliyor.
            fs.Close();
            

            Console.ReadKey();
        }

    }

    class Ev
    {
        double alan = 120;
        int odasayisi;
        public int katno; //'ctrl + .' yaptıktan sonra field seçiyoruz get bloğunda işimiz var ise.
        private string semt = "bebek";

        public string Semt { get => semt; set => semt = value.ToUpper(); }
        public double Alan { get => alan; set => alan = value; }
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs (value); }

        //public void OdaSayisiAta(int odasayisi)
        //{
        //    this.Odasayisi = Math.Abs(odasayisi);
        //}

        public string Evbilgileri() =>
            $"Alan:{this.Alan}\nOda Sayısı: {/*Math.Abs(*/this.Odasayisi/*)*/}\nKatno:{this.katno}\nSemt={this.Semt}";

        public int OdaSayisiBilgi()
        {
            return this.Odasayisi;
        }



    }

    //class Personel
    //{
    //    public double maas;
    //    public byte calismayil;
    //    public double tabanaylik;

    //    //Çalışma yılı ve taban aylık istenecek 'kapsülleme' ile.
    //    //Maaş hesabı: tabanaylik*calismayili
    //    //Girilen personelin bilgilerini ekrana yazdır.

    //    public void CalismaYilAta(byte calismayil)
    //    {
    //        this.calismayil = calismayil;
    //        this.maas = this.calismayil * this.tabanaylik;
    //    }

    //    public byte CalismaYilGetir()
    //    {
    //        return this.calismayil;
    //    }

    //    public void TabanAylikAta(double tabanaylik)
    //    {
    //        this.tabanaylik = tabanaylik;
    //    }

    //    public double TabanAylikGetir()
    //    {
    //        return this.tabanaylik;
    //    }

    //    public string PersonelBilgi() => $"Çalışma Yılı:{this.calismayil}\nTaban Aylık: {this.tabanaylik}\nHesaplanan Maaş:{this.maas}";

    //}

}
