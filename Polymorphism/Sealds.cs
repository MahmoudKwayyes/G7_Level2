public abstract class Aniaml
{
    public abstract int MyProperty { get; set; }
    public abstract void method();
}

public class Birds:Aniaml
{
    public override sealed int MyProperty { get; set; }

    public override sealed void method()
    {
        //Your Code
    }
}

public class x : Birds
{
override 
}