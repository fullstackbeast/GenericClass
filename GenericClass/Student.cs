namespace GenericClass
{
    public class Student : Person
    {
        public string StudentID { get; set; }


        public Student(string firstName, string lastName, string middleName, string studentId) : base(firstName, lastName, middleName)
        {
            StudentID = studentId;
        }
    }
}