namespace Constructor
{
    internal class DestructorDemo
    {
        public int x;
        public DestructorDemo()
        {
            Console.WriteLine("I am a ctor");
        }

        ~DestructorDemo()
        {
            Console.WriteLine("I am a Destructor");
        }
    }
}
