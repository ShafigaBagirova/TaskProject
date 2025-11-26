namespace ConsoleApp1;

public class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public virtual void  ShowInfo()
    {
        Console.WriteLine("Person created");
    }
}
