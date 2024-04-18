using X;

A a=new A();
a.Name="mahmpod";
Console.WriteLine(a.ToString());


namespace X
{
    class A
    {
        public string Name { get; set; }
        public void test()
        {

        }
        public override string ToString()
        {
            return "My Name is: "+ Name;
        }
    }
}
