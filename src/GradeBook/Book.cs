namespace GradeBook
{
    public class Book
    {

        private List<double> grades;
        private string name;
        private double total = 0.0, average = 0.0;
        private double highGrade = double.MinValue;
        private double lowGrade = double.MaxValue;

        // Constructor
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void AddGrade(double newGrade)
        {
            grades.Add(newGrade);
        }

        public string GetName()
        {
            return this.name;
        }

        public string ShowStatistics()
        {
            foreach (double grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
                highGrade = Math.Max(grade, highGrade);
                total += grade;
            }

            return $"The lowest grade is {lowGrade}\n"
                 + $"The highest grade is {highGrade}\n"
                 + $"The average grade is {total / grades.Count}";
        }

    }
}