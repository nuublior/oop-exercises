public class Program
{
    public static void Main(string[] args)
    {
        // Example usage of EnrollmentSystem
        EnrollmentSystem enrollmentSystem = new EnrollmentSystem();

        // Add some students and courses
        Student student1 = new Student("Alice", 1);
        Student student2 = new Student("Bob", 2);
        enrollmentSystem.AddStudent(student1);
        enrollmentSystem.AddStudent(student2);

        Course course1 = new Course("Math 101");
        enrollmentSystem.AddCourse(course1);

        // Enroll students in the course
        enrollmentSystem.Enroll(student1, course1);
        enrollmentSystem.Enroll(student2, course1);

        // Display participants
        Console.WriteLine("Participants in Math 101:");
        enrollmentSystem.ShowParticipants(course1);

        // Display all courses
        Console.WriteLine("\nAll courses:");
        enrollmentSystem.GetCourses();

        // Display all students
        Console.WriteLine("\nAll students:");
        enrollmentSystem.GetStudents();
    }
}
