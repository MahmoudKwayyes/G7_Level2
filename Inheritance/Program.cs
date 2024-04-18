B b = new(100);
b.Value = 1;
//b.Method();

D d = new();

A a=new A();
d.Method(b);

object obj;

obj = "Hello";

obj = 5;

A a2 = b;

public class A
{
    public int Value { get; set; }

    public A()
    {
        Console.WriteLine("From A class");
    }

    public A(int v)
    {
        Value = v;
        Console.WriteLine("Second A Ctor");
    }
}

public class D
{
    public void Method(A a)
    {

    }

    public void Method(object obj)
    {

    }
}
