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

            //Get the exit key from the user.

            int input = 0, last = 0, stopcode;//Değişkenlerin kayıdı ve ataması yapılıyor.

            Console.Write("Sepeti onaylamak için gireceğiniz kod[Sayı]: ");//Çıkış yapmak için kullanıcıdan şifre istenmesi
            stopcode = int.Parse(Console.ReadLine());//Kullanıcıdan şifrenin alınıp değişkene kaydedilmesi
            while (input != stopcode) //Girilen değer Kullanıcı şifresine eşit değilse veri girişine devam edilir.
            {
                for (int i = 1; i < 1000; i++)//Sepete eklenecek ürünler 1.000 adet ile sınırlandırılmıştır.
                {
                    Console.Write(i + ". Ürün fiyatı: ");//Ürün sayısı
                    input = int.Parse(Console.ReadLine());//Fiyatın değişkene kayıdı

                    last = last + input;//Toplamın hesaplanması
                    if (input == stopcode)//Kullanıcı şifresi ile çıkış için girilen değer kontrol ediliyor.
                    {
                        Console.WriteLine("Sepetinizin toplam fiyatı: " + last 
                        + "\n\nPress any button for exit.");//Sonuç yazdırılıyor. Ve çıkış yolu gösteriliyor.
                        Console.ReadKey();//Bir tuşa basılana kadar bekleniyor.
                        break;//while döngüsünden çıkabilmek için break; komutu kullanılıyor. Ve döngü tamamlanıyor.
                    }
                }
            }
        }
    }
}
