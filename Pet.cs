using System;

class Pet
{
    string Name;
    string Type;
    int Age;

    public void SetDetails(string name, string type, int age)
    {
        Name = name;
        Type = type;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + ", Type: " + Type + ", Age: " + Age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter pet's name: ");
        string petName = Console.ReadLine();

        Console.Write("Enter pet's type (e.g., Dog, Cat, Rabbit): ");
        string petType = Console.ReadLine();

        Console.Write("Enter pet's age: ");
        int petAge = int.Parse(Console.ReadLine());

        Pet pet = new Pet();
        pet.SetDetails(petName, petType, petAge);

        pet.DisplayInfo();
    }
}
