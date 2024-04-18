using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal animal = new Mammals();
        animal.Move();

        Mammals mammels = new Mammals();
        mammels.Move();


        Aniaml aniaml = new Aniaml();
    }
}