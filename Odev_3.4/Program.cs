using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Bir alışveriş uygulaması geliştirmekte olan bir yazılım ekibi,
            kullanıcıların sepetlerine ekledikleri ürünlerin toplam fiyatını
            hesaplamalarını isteyen bir özellik eklemek istiyor. Kullanıcı,
            sepetine eklediği ürünlerin fiyatlarını girecek,
            ardından program toplam fiyatı hesaplayacak ve ekrana yazdıracaktır.
            */

            //Exit code "0"

            int input = 1, last = 0;//Değişkenlerin kayıdı ve ataması yapılıyor.

            Console.WriteLine("Send for exit '0': ");//Çıkış yapmak için kullanıcıdan "0" girmesini bildirmek.
            
            while (input != 0) //Girilen değer Kullanıcı şifresine eşit değilse veri girişine devam edilir.
            {
                for (int i = 1; i < 1000; i++)//Sepete eklenecek ürünler 1.000 adet ile sınırlandırılmıştır.
                {
                    Console.Write(i + ". Ürün fiyatı: ");//Ürün sayısı
                    input = int.Parse(Console.ReadLine());//Fiyatın değişkene kayıdı

                    last = last + input;//Toplamın hesaplanması
                    if (input == 0)//Çıkış için girilen değer kontrol ediliyor.
                    {
                        Console.WriteLine("\nSepetinizin toplam fiyatı: " + last +" USD"
                        + "\nİyi Günler diler, yine bekleriz." +
                        "\n\nPress any button for exit.");//Sonuç yazdırılıyor. Ve çıkış yolu gösteriliyor.
                        Console.ReadKey();//Bir tuşa basılana kadar bekleniyor.
                        break;//while döngüsünden çıkabilmek için break; komutu kullanılıyor. Ve döngü tamamlanıyor.
                    }
                }
            }
        }
    }
}
