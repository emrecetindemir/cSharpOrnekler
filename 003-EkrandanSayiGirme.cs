class program{
    static void Main (string [] args){
        Console.Write("Bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan sayıyı alıyoruz.
        Console.WriteLine("Girdiğiniz sayı:"+sayi); //Sayıyı ekrana yazdırıyoruz.
        Console.ReadKey();
    }
}
