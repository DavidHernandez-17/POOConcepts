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
//Console.WriteLine(employee1);

//Console.WriteLine("");

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
}; 
//Console.WriteLine(employee2);

//Console.WriteLine("");

Employee employee3 = new HourlyEmployee()
{
    Id = 1923,
    FirsName = "Dayeny",
    LastName = "Martinez",
    BirthDate = new Date(2019, 7, 12),
    HiringDate = new Date(2001, 9, 29),
    IsActive = true,
    HourValue = 12356.56M,
    Hours = 123.5F
}; 
//Console.WriteLine(employee3);
//Console.WriteLine("");

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirsName = "Jazmin",
    LastName = "Salazar",
    BirthDate = new Date(2016, 2, 1),
    HiringDate = new Date(2001, 9, 29),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000,
    CommissionPercentaje = 0.015F
}; /*Console.WriteLine(employee4);*/


ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};


decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                              ================");
Console.WriteLine($"TOTAL.........................:{$"{payroll:C2}",15}");

Invoice invoice1 = new Invoice()
{
    Id = 1,
    Description = "iPhone 13",
    Price = 5300000M,
    Quantity = 6

};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "Posta Premium",
    Price = 32000M,
    Quantity = 17.5F

};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);