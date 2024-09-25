using System;

namespace AverageGradesExceptions
{
    // Custom exception class for failing grades
    public class AvgGradeError : Exception
    {
        public AvgGradeError(string message) : base(message) { }
    }

    // Main program class
    public class Program
    {
        // Grades array
        static int[] grades = { 4, 7, 2, 0, 10, 4, 12 };

        // Method to get a grade based on course ID
        public static int GetGrade(int courseid)
        {
            int grade = grades[courseid];

            if (grade == 0)
            {
                throw new AvgGradeError("Failing grade encountered.");
            }

            return grade;
        }

        // Main method
        public static void Main(string[] args)
        {
            int count = 0;
            int sum = 0;

            for (int courseid = 0; courseid < grades.Length; courseid++)
            {
                try
                {
                    int grade = GetGrade(courseid);
                    count++;
                    sum += grade;
                }
                catch (AvgGradeError e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            if (count > 0)
            {
                Console.WriteLine("Average grade: " + (sum / count));
            }
            else
            {
                Console.WriteLine("No valid grades found.");
            }
        }
    }
}
