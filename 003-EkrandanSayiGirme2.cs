class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine()); //Kullanıcıdan sayıyı alıyoruz.
            Console.WriteLine("Girdiğiniz sayı:" + sayi); //Sayıyı ekrana yazdırıyoruz.
            Console.ReadKey();
        }
    }