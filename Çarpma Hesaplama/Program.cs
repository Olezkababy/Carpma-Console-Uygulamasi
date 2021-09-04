using System;

namespace Çarpma_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sonuc;
            string islem1, islem2;
            Console.WriteLine("Çarpma İşlemleri C# Uygulama \nBu yeni başlıyan öğrenciler için örnek için paylaşılmıştır. Ufuk Gökalp");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\n");
            Console.WriteLine("Lütfen çarpmak istediğiniz birinci sayıyı giriniz!");
            islem1 = Console.ReadLine();
            Console.WriteLine("Lütfen ikinci sayıyı giriniz!");
            islem2 = Console.ReadLine();
            a = Convert.ToInt32(islem1);
            b = Convert.ToInt32(islem2);
            sonuc = a * b;
            Console.WriteLine("Çarpma İşlemi Sonucu : " + sonuc + " ");
            Console.ReadLine();
        }
    }
}
