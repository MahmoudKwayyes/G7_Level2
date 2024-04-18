
using Delegates;

internal class Program
{
    public delegate string MyDelegate(int num);
    private static void Main(string[] args)
    {
        #region Old code
        //MyDelegate md= new MyDelegate(m1);
        //MyDelegate md;

        //md += m2;

        //md += m3;

        //test(m1);

        //md =  (num) => $"your parmeter is {num}, form m1";

        //test((n) => "Hellooooooooo");
        #endregion

        Demo demo = new Demo();

        demo.Search((x) => x > 60, 55);
        demo.Search((x) => x < 59, 55);
        demo.Search((x) => x > 40 && x< 60, 55);

        List<string> students = new();

        students.Where(s => s=="abc");

    }

    static bool m1(double x) => x > 60;

    //static string m1(int num) => $"your parmeter is {num}, form m1";


    //static string m2(int num) => "Hello i am m2";


    //static string m3(int num) => "Hello i am m3";

    //static void test(MyDelegate m)
    //{
    //    // .....code
    //    m(4);
    //    //.... code
    //}

}




