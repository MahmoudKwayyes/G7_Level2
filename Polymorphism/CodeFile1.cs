namespace Polymorphism;
public abstract class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Moving");
    }
}
public class Mammals : Animal
{
    public new void Move()
    {
        Console.WriteLine("Walking..");
    }
}

public class Birds : Animal
{
    public void Move()
    {
        Console.WriteLine("Fly..");
    }
}

