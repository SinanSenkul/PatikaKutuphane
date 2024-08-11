using System;

namespace PatikaKutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
            Console.WriteLine($"birinci kitap adı: {book1.Name} kayıt tarihi: {book1.PubDate}");
            Console.WriteLine($"ikinci kitap adı: {book2.Name} kayıt tarihi: {book2.PubDate}");
        }
    }
}