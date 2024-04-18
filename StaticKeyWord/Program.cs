Console.WriteLine(User.UsersCount);


//User u1 = new User();
//u1.Name = "u1";
//Console.WriteLine("User name: "+ u1.Name);
//Console.WriteLine("Users count is: " + User.UsersCount);
//Console.WriteLine("----------------------");
//User u2 = new User();
//u2.Name = "u2";
//Console.WriteLine("User name: " + u2.Name);
//Console.WriteLine("Users count is: " + User.UsersCount);
//Console.WriteLine("----------------------");
//User u3 = new User();
//u3.Name = "u3";
//Console.WriteLine("User name: " + u3.Name);
//Console.WriteLine("Users count is: " + User.UsersCount);



public class User
{
    public string Name;
    public static int UsersCount=0;

    public User()
    {
        Console.WriteLine("Non Static");
        UsersCount++;
    }

    static User()
    {
        Console.WriteLine("Static CTOR");
        Console.WriteLine("Hellooooooooooooooooooooooo");
    }

    public static void Method()
    {

    }
}

