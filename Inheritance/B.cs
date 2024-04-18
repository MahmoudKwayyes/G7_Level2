//b.Method();


class B : A
{
    public B():base(50)
    {
        Console.WriteLine("From B class");
    }

    public B(int x)
    {
        Value=x;
        Console.WriteLine("Second B Ctor");
    }

    public void Method()
    {
        Console.WriteLine(Value);
    }
}
