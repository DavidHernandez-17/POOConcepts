namespace POOConcepts
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} - {FirsName} {LastName}," +
                $" Birth: {BirthDate}, " +
                $"Hiring: {HiringDate}, " +
                $"IsActive: {IsActive}";
        }

    }
}