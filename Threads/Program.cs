// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

Console.WriteLine("main process id: "+Process.GetCurrentProcess().Id);
//Console.WriteLine("process process name: "+Process.GetCurrentProcess().ProcessName);
//Console.WriteLine("process  MachineName: " + Process.GetCurrentProcess().MachineName);
//Console.WriteLine("process  MachineName: " + Process.GetCurrentProcess());
//Console.WriteLine(  "---------------");
Console.WriteLine("main thread: "+Thread.CurrentThread.ManagedThreadId);
//Console.WriteLine(Thread.CurrentThread);

Register();

Console.ReadKey();

void Register()
{
    Thread t1 = new Thread(isValid);
    Thread t2 = new Thread(ConfirmEmail);

    t1.Start();

    t2.Start();

    t1.Join();


    //isValid();
    //ConfirmEmail();
}


void isValid()
{
    Thread.Sleep(10000);
    Console.WriteLine("validaion process id: " + Process.GetCurrentProcess().Id);

    Console.WriteLine("Validation thread id: " + Thread.CurrentThread.ManagedThreadId);

    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine("Validation ..." + i);
    }
}

void ConfirmEmail()
{
    Console.WriteLine("confirmation process id: " + Process.GetCurrentProcess().Id);

    Console.WriteLine("Confirmation thread id: "+ Thread.CurrentThread.ManagedThreadId);
    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine("Confirming ..."+i);
    }
}



/*
//m1();
//Console.WriteLine("---------");
//m2();


Thread t1 = new Thread(m1);
Thread t2 = new Thread(m2);

t1.Start();

t1.Join();

t2.Start();

static void m1()
{
    for (int i = 0; i < 30; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("m1...");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

static void m2()
{
    for (int i = 0; i < 30; i++)
    {
    Console.ForegroundColor = ConsoleColor.Blue;

        Console.WriteLine("m2...");
    Console.ForegroundColor = ConsoleColor.White;
    }

} 
*/