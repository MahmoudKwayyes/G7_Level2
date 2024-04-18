using Constructor;
using System.Security.Cryptography.X509Certificates;

DestructorDemo? demo = new()
{
    x = 3
};
Console.WriteLine(demo.x);
demo = null;
GC.Collect();
GC.WaitForPendingFinalizers();



Console.WriteLine("Finished");


//User user = new User();
//user.Id = 1;
//user.Name = "Mahmoud";
//user.Username = "Abo Hamdo";
//user.Password = "123";
//Console.WriteLine(user.CreatedAt);
////Console.WriteLine(user.cea);


int user2Id = Convert.ToInt32(Console.ReadLine());
string user2Name = Console.ReadLine();
User user2 = new User(user2Id, user2Name, "abcd", "123qwe");

user2.Name = "ab";
Console.ReadKey();

public class User
{
    public int Id;
    public string Name;
    public string Username;
    public string  Password;
    public readonly DateTime CreatedAt = DateTime.Now;

    ~User()
    {
        //Disconnect();
    }

    public User() : this(2, "Test", "Test", "123")
    {
    }

    public User(int id, string name):this(id, name, "Test", "123")
    {
        Console.WriteLine("scond ctor, name{0}, id{1}",name, id);
    }

    void method()
    {
    }
    public User(int id, string name, string username, string password)
    {
        Id = id;
        if(name.Length<3)
        {
            Console.WriteLine("pleas enter more letters");
        }
        else
        {
            Name = name;
        }
        Username = username;
        Password = password;
        CreatedAt = DateTime.Now;
    }

}


//public class User
//{
//    public int Id;
//    public string Name;
//    public string Username;
//    public string Password;
//    private DateTime CreatedAt;

//    public User()
//    {
//        Name= "Test";
//        DefaultUserNameAndPassword();
//        DefaultCreatedAt();
//    }
//    public User(int id, string name)
//    {
//        Id = id;
//        Name = name;
//        DefaultUserNameAndPassword();
//        DefaultCreatedAt();
//    }
//    public User(int id, string name, string username, string password)
//    {
//        Id = id;
//        Name = name;
//        Username = username;
//        Password = password;
//        DefaultCreatedAt();
//    }

//    public void DefaultCreatedAt()
//    {
//        CreatedAt = DateTime.UtcNow;
//    }

//    public void DefaultUserNameAndPassword()
//    {
//        Username = "Test";
//        Password = "Test";
//    }
//}
