namespace GenericClass
{
    public class Teacher : Person
    {
        public string StaffId { get; set; }

        public Teacher(string firstName, string lastName, string middleName, string staffId) : base(firstName, lastName, middleName)
        {
            StaffId = staffId;
        }
    }
}