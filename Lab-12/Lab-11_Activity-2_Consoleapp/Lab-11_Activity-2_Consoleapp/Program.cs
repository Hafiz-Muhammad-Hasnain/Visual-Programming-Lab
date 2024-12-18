using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExample
{
    class Program
    {
        // Define the Student class
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public int GradeLevel { get; set; } // e.g., 1 for 1st grade, 10 for 10th grade
            public List<int> ExamScores { get; set; }

            // Constructor
            public Student(string firstName, string lastName, int id, int gradeLevel, List<int> examScores)
            {
                FirstName = firstName;
                LastName = lastName;
                ID = id;
                GradeLevel = gradeLevel;
                ExamScores = examScores;
            }

            // Method to display student information
            public void DisplayInfo()
            {
                Console.WriteLine($"ID: {ID}, Name: {FirstName} {LastName}, Grade Level: {GradeLevel}");
                Console.WriteLine("Exam Scores: " + string.Join(", ", ExamScores));
                Console.WriteLine($"Average Score: {ExamScores.Average():F2}");
                Console.WriteLine($"Highest Score: {ExamScores.Max()}");
                Console.WriteLine();
            }

            // Method to calculate percentile
            public double CalculatePercentile(int totalStudents, int rank)
            {
                if (totalStudents <= 0)
                {
                    throw new ArgumentException("Total number of students must be greater than zero.");
                }
                if (rank < 1 || rank > totalStudents)
                {
                    throw new ArgumentOutOfRangeException("Rank must be between 1 and the total number of students.");
                }

                return ((double)(totalStudents - rank) / totalStudents) * 100;
            }
        }

        static void Main(string[] args)
        {
            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student("Ali", "Khan", 101, 10, new List<int> { 85, 90, 78 }),
                new Student("Aisha", "Bibi", 102, 9, new List<int> { 88, 92, 80 }),
                new Student("Omar", "Farooq", 103, 11, new List<int> { 75, 80, 70 }),
                new Student("Fatima", "Saeed", 104, 10, new List<int> { 95, 100, 90 }),
                new Student("Zain", "Malik", 105, 12, new List<int> { 60, 70, 65 })
            };

           
            Console.WriteLine("Student Information:");
            int totalStudents = students.Count;

           
            var rankedStudents = students
                .Select((student, index) => new { Student = student, Rank = index + 1 })
                .OrderByDescending(s => s.Student.ExamScores.Average())
                .ToList();

            foreach (var rankedStudent in rankedStudents)
            {
                var student = rankedStudent.Student;
                student.DisplayInfo();
                double percentile = student.CalculatePercentile(totalStudents, rankedStudent.Rank);
                Console.WriteLine($"Percentile: {percentile:F2}%");
            }

           
            Console.ReadLine();
        }
    }
}