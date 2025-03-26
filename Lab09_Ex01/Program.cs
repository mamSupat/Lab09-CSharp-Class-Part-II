// See https://aka.ms/new-console-template for more information
Person.name="Mam";
System.Console.WriteLine(Person.Getname());

static class Person
{
    public static string name;
    public static string Getname()
    {
        return $"Hello from {name}"; 
    }
}
