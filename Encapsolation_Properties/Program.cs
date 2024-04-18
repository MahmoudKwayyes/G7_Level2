// See https://aka.ms/new-console-template for more information
TestEncapso test = new(12);

test.SetAge(1);


public class TestEncapso
{
    private int Age;

    public int SetAge(int age)
    {
        if (age < 10 || age > 70)
            Age = age;

        return Age;
    }

    //public int GetAge()
    //{
    //    return Age;
    //}

    public TestEncapso(int age)
    {
        if (age < 10 || age > 70)
            Age = age;
    }
}