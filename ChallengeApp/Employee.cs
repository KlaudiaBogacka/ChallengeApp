namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var Statistics = new Statistics();
            Statistics.Average = 0;
            Statistics.Max = float.MinValue;
            Statistics.Min = float.MaxValue;
            Statistics.Sum = 0;

            foreach (var grade in this.grades)
            {
                Statistics.Max = Math.Max(Statistics.Max, grade);
                Statistics.Min = Math.Min(Statistics.Min, grade);
                Statistics.Average += grade;
                Statistics.Sum += grade;
            }

            Statistics.Average /= this.grades.Count;
            return Statistics;
        }
        
    } 
}
