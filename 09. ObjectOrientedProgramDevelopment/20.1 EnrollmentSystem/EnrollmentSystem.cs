public class EnrollmentSystem
{
    public Student?[] students;
    public Course?[] courses;

    public EnrollmentSystem()
    {
        students = new Student?[10]; // Fixed size for simplicity
        courses = new Course?[10];   // Fixed size for simplicity
    }

    public void Enroll(Student student, Course course)
    {
        course.Enroll(student);
    }

    public void Remove(Student student, Course course)
    {
        course.Remove(student);
    }

    public void ShowParticipants(Course course)
    {
        foreach (Student student in course.GetParticipants())
        {
            Console.WriteLine(student.GetName());
        }
    }

    public void GetCourses()
    {
        foreach (Course? course in courses)
        {
            if (course != null) Console.WriteLine(course.name);
        }
    }

    public void GetStudents()
    {
        foreach (Student? student in students)
        {
            if (student != null) Console.WriteLine(student.GetName());
        }
    }

    public void AddStudent(Student student)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == null)
            {
                students[i] = student;
                return;
            }
        }
    }

    public void RemoveStudent(Student student)
    {
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] == student)
            {
                students[i] = null;
                return;
            }
        }
    }

    public void AddCourse(Course course)
    {
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] == null)
            {
                courses[i] = course;
                return;
            }
        }
    }

    public void RemoveCourse(Course course)
    {
        for (int i = 0; i < courses.Length; i++)
        {
            if (courses[i] == course)
            {
                courses[i] = null;
                return;
            }
        }
    }
}