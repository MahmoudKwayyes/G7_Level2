
using System.Collections;

print(8);
print<int>(5);
print<bool>(true);
static void print<T>(T x)
{
    Console.WriteLine(x);
}


Repository<int> repo1 = new Repository<int>(10);
repo1.Add(10);
repo1.Add(35);
int item1 = repo1.GetItem(1); // 35

Repository<string> repo2 = new Repository<string>(3);
repo2.Add("Mahmoud");
repo2.Add("Omar");
string item2 = repo2.GetItem(0); // Mahmoud

//Repository<product> p = new Repository<product>();

List<int> list = new List<int>();

list.Add(3);
list.Add("dd");

ArrayList list2 = new ArrayList();
list2.Add("dd");
list2.Add(5);

public class product
{
    public product(int x)
    {
        
    }
}

class Repository<T> where T: class, new()
{
    T[] items;
    public Repository(int n)
    {
        items = new T[n];
    }
    public void Add(T item)
    {
        if(item == null)
            throw AddExc
        items[0] = item;
    }
    public T GetItem(int position)
    {
        return items[position];
    }
}

//static void print(object x)
//{
//    Console.WriteLine(x);
//}