namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;

                case "-6":
                case "6-":

                    this.grades.Add(95);
                    break;

                case "5":
                    this.grades.Add(80);
                    break;

                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;

                case "4":
                    this.grades.Add(60);
                    break;

                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;

                case "3":
                    this.grades.Add(40);
                    break;

                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;

                case "2":
                    this.grades.Add(20);
                    break;

                case "-2":
                case "2-":
                    this.grades.Add(15);
                    break;

                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;

                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Do oceny możesz używać tylko ocen: 6, -6, 6-, 5, -5, 5-, 4, -4, 4-, 3, -3, 3-, 2, -2, 2-, 1, -1, 1-");
            }
        }

        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatistics()
        {

            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
