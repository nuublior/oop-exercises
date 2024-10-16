public class Course
{
    public string name;
    public Student?[] participants;

    public Course(string nameValue)
    {
        name = nameValue;
        participants = new Student?[10]; // Fixed size for simplicity
    }

    public void Enroll(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == null)
            {
                participants[i] = student;
                return;
            }
        }
    }

    public void Remove(Student student)
    {
        for (int i = 0; i < participants.Length; i++)
        {
            if (participants[i] == student)
            {
                participants[i] = null;
                return;
            }
        }
    }

    public Student[] GetParticipants()
    {
        int count = 0;
        foreach (Student? student in participants)
        {
            if (student != null) count++;
        }

        Student[] result = new Student[count];
        int index = 0;
        foreach (Student? student in participants)
        {
            if (student != null)
            {
                result[index++] = student;
            }
        }
        return result;
    }
}