
namespace GradeBook {
    class Program {
        static void Main(string[] args) {
            
            Book book = new Book("Jason's Book");

            book.AddGrade(89.1);

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};

            double total = 0.0, average = 0.0;
            
            foreach (var grade in grades) {
                total += grade;
            } 

            average = total / grades.Count;

            Console.WriteLine($"The total sum of grades is {total}");
            Console.WriteLine($"The average grades is {average:N1}");
        }
    }
}
