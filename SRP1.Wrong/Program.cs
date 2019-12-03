
namespace SRP.Wrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book { Title = "Clean Code", Author = "Robert C. Martin"};
            book.TurnPage();
            book.PrintCurrentPage();
        }
    }
}
