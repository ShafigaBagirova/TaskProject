// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Person person = new()
{
    Name = "Shafiga",
    Surname = "Bagirova"
};
Manager manager = new()
{ 
    Name="Aysel",
     Surname="Ehmedova"
};

Developer developer = new ()
{
    Name = "Gunel",
    Surname = "Elyeva"
};
developer.ShowInfo();
person.ShowInfo();
manager.ShowInfo();


