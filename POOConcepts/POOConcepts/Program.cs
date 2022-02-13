

using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("_____________");

try
{
    Console.WriteLine(new Date(2024, 02, 29));
    Console.WriteLine(new Date(1992, 2, 7));
    Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}