﻿using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;

        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if(grade >= 0 && grade <= 100)
            {
                using var writer = File.AppendText(fileName) ;
                writer.WriteLine(grade);
            }
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
        }

        public override void AddGrade(string grade)
        {
            using var writer = File.AppendText(fileName);
            switch (grade)
            {
                case "6":
                    writer.WriteLine(100);
                    break;

                case "-6":
                case "6-":

                    writer.WriteLine(95);
                    break;

                case "5":
                    writer.WriteLine(80);
                    break;

                case "-5":
                case "5-":
                    writer.WriteLine(75);
                    break;

                case "4":
                    writer.WriteLine(60);
                    break;

                case "-4":
                case "4-":
                    writer.WriteLine(55);
                    break;

                case "3":
                    writer.WriteLine(40);
                    break;

                case "-3":
                case "3-":
                    writer.WriteLine(35);
                    break;

                case "2":
                    writer.WriteLine(20);
                    break;

                case "-2":
                case "2-":
                    writer.WriteLine(15);
                    break;

                case "+1":
                case "1+":
                    writer.WriteLine(5);
                    break;

                case "1":
                    writer.WriteLine(0);
                    break;
                default:
                    throw new Exception("Do oceny możesz używać tylko ocen: 6, -6, 6-, 5, -5, 5-, 4, -4, 4-, 3, -3, 3-, 2, -2, 2-, 1, -1, 1-");
            }
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
        {
            using var writer = File.AppendText(fileName);
            switch (grade)
            {
                case 'A':
                case 'a':
                    writer.WriteLine(100);
                    break;
                case 'B':
                case 'b':
                    writer.WriteLine(80);
                    break;
                case 'C':
                case 'c':
                    writer.WriteLine(60);
                    break;
                case 'D':
                case 'd':
                    writer.WriteLine(40);
                    break;
                case 'E':
                case 'e':
                    writer.WriteLine(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float>ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }  
        
        private Statistics CountStatistics(List<float>grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= grades.Count;

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
