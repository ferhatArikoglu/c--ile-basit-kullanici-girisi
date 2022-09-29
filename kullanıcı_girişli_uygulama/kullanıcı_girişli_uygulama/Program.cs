using System;

namespace kullanıcı_girişli_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sifre;
            string kullanici;
            Console.WriteLine("kullanıcı adını giriniz");
            kullanici = Console.ReadLine();
            Console.WriteLine("şifrenizi giriniz");
            sifre = Convert.ToInt32(Console.ReadLine());
            if (sifre == 123 && kullanici == "ferhat")
            {
                Console.WriteLine("bilet alma uygulamasına hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("kullanıcı adı veya şifreniz yanlış girilmiştir");
            }
        }
    }
}
