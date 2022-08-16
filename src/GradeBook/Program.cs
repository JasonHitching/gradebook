
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Jason's Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            string stats = book.ShowStatistics();

            Console.WriteLine(stats);
        }
    }
}
