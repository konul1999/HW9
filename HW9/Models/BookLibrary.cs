
namespace HW9.Models
{
    internal class BookLibrary
    {
        private string _name;
        private Book[] _books = new Book[0];

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public void Remove(Book book)
        {
            int index = Array.IndexOf(_books, book);
            if (index >= 0)
            {
                for (int i = index; i < _books.Length - 1; i++)
                {
                    _books[i] = _books[i + 1];
                }
                Array.Resize(ref _books, _books.Length - 1);
            }
        }

        public void ShowAll()
        {
            foreach (var book in _books)
            {
                book.GetInfo();
            }
        }

        public void BorrowBook(string name)
        {
            foreach (var book in _books)
            {
                if (book.Name == name && book.IsAvailable)
                {
                    book.IsAvailable = false;
                    Console.WriteLine($"'{name}' kitabı oxucuya verildi.");
                    return;
                }
            }
            Console.WriteLine($"'{name}' kitabı tapılmadı və ya artıq verilib.");
        }

        public void ReturnBook(string name)
        {
            foreach (var book in _books)
            {
                if (book.Name == name && !book.IsAvailable)
                {
                    book.IsAvailable = true;
                    Console.WriteLine($"'{name}' kitabı geri qaytarıldı.");
                    return;
                }
            }
            Console.WriteLine($"'{name}' kitabı tapılmadı və ya əvvəlcədən mövcuddur.");
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;
            foreach (var book in _books)
            {
                if (book.Author == author)
                {
                    book.GetInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"{author} adlı müəllifin kitabı tapılmadı.");
            }
        }
    }
}
    
