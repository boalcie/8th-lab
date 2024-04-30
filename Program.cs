using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}
public interface IWalkable
{
    void Walk();
}


public class Dog : Animal,IWalkable
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.Breed = breed;
    }

    public void Walk()
    {
        Console.WriteLine($"{Name} гуляє");
    }
}
class Program
{
    static void Main()
    {
        Dog myDog = new Dog("Гідродезинтегратор",3000,"Велика");
        myDog.Walk();
    }
}