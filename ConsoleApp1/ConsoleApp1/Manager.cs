namespace ConsoleApp1;

public class Manager:Person
{
    public override void ShowInfo()
    {
        Console.WriteLine($"Manager:{Name} Manager: {Surname}");
    }
}
