using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{

    class ThreadsVSTasks
    {
        void method()
        {

            Console.WriteLine("Main thread id: " + Thread.CurrentThread.ManagedThreadId);

            Thread t = new Thread(() =>
            {
                Console.WriteLine("using our thread");
                Console.WriteLine("t1 id: " + Thread.CurrentThread.ManagedThreadId);
            });
            t.Start();

            Task task = new(() =>
            {
                Console.WriteLine("using our beautifull Task");
                Console.WriteLine("task id: " + Thread.CurrentThread.ManagedThreadId);
            });
            task.Start();


            Console.WriteLine("Anonymous thread id: " + Thread.CurrentThread.ManagedThreadId);
            //Task.Run(() => Console.WriteLine("using our beautifull Task"));

            //Console.WriteLine("thread....");
            //Console.WriteLine("is back" + Thread.CurrentThread.IsBackground);
            //Console.WriteLine("is pooled" + Thread.CurrentThread.IsThreadPoolThread);
            ////Console.WriteLine("is back" + t.);


            //Console.WriteLine("task....");
            //Console.WriteLine("is pooled");
        }
    }
}
