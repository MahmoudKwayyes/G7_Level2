
Engineer e = new();


Person p = e;

e.Name = "Test";
e.Age = 1;
e.GetPersonData();

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract int MyProperty { get; set; }

    public abstract void GetPersonData();
}

public class Engineer:Person
{
    public override int MyProperty { get; set; } = 2;
    
    public override void GetPersonData()
    {
    }
}
public class Employee:Person
{

}


public interface IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public void GetUserData();
}

public class Admin : IUser
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }

    public void GetUserData()
    {
    }
}
