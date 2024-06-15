using System;

//class Animal

class Program
{
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Console.WriteLine("Inheritance and Method Overriding:");
        Animal animal = new Animal();
        animal.MakeSound();

        Dog dog = new Dog();
        dog.MakeSound();

        Cat cat = new Cat();
        cat.MakeSound();
        Console.WriteLine();

        // Abstract Classes and Methods
        Console.WriteLine("Abstract Classes and Methods:");
        Shape circle = new Circle(5);
        Console.WriteLine("Area of Circle: " + circle.GetArea());

        Shape rectangle = new Rectangle(4, 5);
        Console.WriteLine("Area of Rectangle: " + rectangle.GetArea());
        Console.WriteLine();

        // Interfaces
        Console.WriteLine("Interfaces:");
        IMovable car = new Car();
        car.Move();

        IMovable bicycle = new Bicycle();
        bicycle.Move();
    }
}
