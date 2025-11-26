namespace ConsoleApp1;

public class Developer:Person
{
    public override void ShowInfo()
    {
        Console.WriteLine($"Developer:{Name} Developer: {Surname}");
    }
}
