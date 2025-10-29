public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Have to get the name of the student but is private so have to set and get it in here
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}