namespace GradeBook {
    public class Book {

        private List<double> grades;
        private string name;

        // Constructor
        public Book(string name) {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double newGrade) {
            grades.Add(newGrade);
        }

        public string GetName() {
            return this.name;
        }

    }
}