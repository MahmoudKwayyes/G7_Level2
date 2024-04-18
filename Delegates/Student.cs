using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Avg { get; set; }
    }

    public class Demo
    {
        public List<Student> students =
            [
                new Student(){Id=1, Name="Mhamoud", Avg=99.99},
                new Student(){Id=1, Name="ahmad", Avg=49},
                new Student(){Id=1, Name="wael", Avg=55},
                new Student(){Id=1, Name="Enas", Avg=99.99},
                new Student(){Id=1, Name="salim", Avg=58.5}
            
            ];
        public delegate bool StudentDelegate(double avg);
        public Demo()
        {
            students = new List<Student>();
        }

        public void Search(StudentDelegate studentDelegate, double avg)
        {
            foreach (var student in students)
            {
                if (studentDelegate(avg))
                    Console.WriteLine(student.Name);
            }
        }

        //public void SearchLessThan(Students s)
        //{
        //    foreach (var student in students)
        //    {
        //        if(student.Avg < s.Avg)
        //            Console.WriteLine(student.Name);
        //    }
        //}
        //public void SearchGreaterThan(double avg)
        //{
        //    foreach (var student in students)
        //    {
        //        if ( student.Avg > avg)
        //            Console.WriteLine(student.Name);
        //    }
        //}

        //public void SearchBetween55And59(double avg)
        //{
        //    foreach (var student in students)
        //    {
        //        if (55 > avg && avg < 59)
        //            Console.WriteLine(student.Name);
        //    }
        //}

    }


}
