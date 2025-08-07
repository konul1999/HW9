using HW9.Models;

namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Name = "Cinayet ve Ceza", Author = "Dostoyevski" };
            Book book2 = new Book { Name = "Insan ne ile yashayir", Author = "Tolstoy" };
            Book book3 = new Book { Name = "Sefiller", Author = "Hugo" };

            BookLibrary library = new BookLibrary { Name = "Milli Kitabxana" };

            library.Add(book1);
            library.Add(book2);
            library.Add(book3);

            Console.WriteLine(" Kitabxanadakı bütün kitablar ");
            library.ShowAll();

            Console.WriteLine(" Kitab oxucuya verildi (Borrow) ");
            library.BorrowBook("Cinayet ve Ceza");

            Console.WriteLine(" Kitablar (yenidən göstər) ");
            library.ShowAll();

            Console.WriteLine(" Kitab geri qaytarıldı (Return) ");
            library.ReturnBook("Cinayet ve Ceza");

            Console.WriteLine(" Tolstoy müəllifinə görə axtarış ");
            library.SearchByAuthor("Tolstoy");

            Console.WriteLine(" Hugo müəllifinə görə axtarış ");
            library.SearchByAuthor("Hugo");
        }
    
    }
}
