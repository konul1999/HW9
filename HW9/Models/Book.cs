
namespace HW9.Models
{
    internal class Book
    {
        private string _name;
        private string _author;
        private bool _isAvailable = true;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, Author: {_author}, Available: {_isAvailable}");
        }
    }
}
  
