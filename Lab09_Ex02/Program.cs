// See https://aka.ms/new-console-template for more information
Person.name="Supattra";
System.Console.WriteLine(Person.Getname());

static class Person
{
     static public  string name;
     static public string Getname()
    {
       
        return $"Hello from {name}"; 
    }
}
