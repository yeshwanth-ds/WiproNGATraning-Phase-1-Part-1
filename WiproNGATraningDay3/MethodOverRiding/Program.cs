using System;

namespace MethodOverridingExample
{
    // Base class
    class Animal
    {
        // Virtual method, can be overridden in derived classes
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding the Speak method
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Derived class
    class Cat : Animal
    {
        // Overriding the Speak method
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Creating an instance of the base class and calling the overridden method
            Animal myAnimal = new Animal();
            myAnimal.Speak();  // Output: Animal makes a sound

            // Creating an instance of the derived class Dog and calling the overridden method
            Animal myDog = new Dog();
            myDog.Speak();  // Output: Dog barks

            // Creating an instance of the derived class Cat and calling the overridden method
            Animal myCat = new Cat();
            myCat.Speak();  // Output: Cat meows
        }
    }
}
