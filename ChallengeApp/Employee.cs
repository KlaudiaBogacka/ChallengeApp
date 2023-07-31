using System.ComponentModel.Design;

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
            // 3.33
            // 3

            int valueinInt = (int)grade;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }   
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade((float) result);
        }
        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade((float)result);
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
