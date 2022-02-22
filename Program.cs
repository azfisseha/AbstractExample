Animal pig = new Pig();
pig.makeNoise();
pig.Sleep();
Animal dog = new Dog();
dog.makeNoise();
dog.Sleep();
Animal cat = new Cat();
cat.makeNoise();
cat.Sleep();
Animal bird = new Bird();
bird.makeNoise();
bird.Sleep();

Console.WriteLine("Now let's look at what a dinosaur says");
Animal dino = new Dinosaur();
dino.makeNoise();
dino.Sleep();


public abstract class Animal
{
    public String name { get; set; }
    public abstract void makeNoise();

    public virtual void Sleep()
    {
        Console.WriteLine("zzzzzzzzzzzzzzzz");
    }
}

public class Pig : Animal
{
    public Pig()
    {
        name = "MrOink";
    }
    public override void makeNoise()
    {
        Console.WriteLine($"{name} says Oink");
    }
}

public class Dog : Animal
{
    public Dog()
    {
        name = "Chuckles";
    }
    public override void makeNoise()
    {
        Console.WriteLine($"{name} says Bark");
    }
}

public class Cat : Animal
{
    public Cat()
    {
        name = "Kitty";
    }
    public override void makeNoise()
    {
        Console.WriteLine($"{name} says Meow");
    }
}

public class Bird : Animal
{
    public Bird()
    {
        name = "Twitter";
    }
    public override void makeNoise()
    {
        Console.WriteLine($"{name} says Chirp");
    }

    public override void Sleep()
    {
        Console.WriteLine("birds dont sleep");
    }
}

public class Dinosaur : Animal
{
    public Dinosaur()
    {
        name = "T-Rex-Osaurus";
    }

    public override void makeNoise()
    {
        Console.WriteLine($"{name} can't make noise, he is extinct");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{name} has been asleep for a very long time, and doesn't snore anymore.");
    }
}