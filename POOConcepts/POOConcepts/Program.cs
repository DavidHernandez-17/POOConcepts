using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirsName = "Cristina",
    LastName = "Arango",
    BirthDate = new Date(1998, 5, 24),
    HiringDate = new Date(2022, 11, 4),
    IsActive = true,
    Salary = 1815453.45M
};

Console.WriteLine(employee1);

Console.WriteLine("");

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirsName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1994, 5, 25),
    HiringDate = new Date(2022, 11, 13),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
}; Console.WriteLine(employee2);
