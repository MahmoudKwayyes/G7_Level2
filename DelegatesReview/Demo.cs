using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesReview
{
    public static class Demo
    {
        public static List<Student> students =
           [
               new Student(){Id=1, Name="Mhamoud", Avg=99.99},
                new Student(){Id=1, Name="ahmad", Avg=49},
                new Student(){Id=1, Name="wael", Avg=55},
                new Student(){Id=1, Name="Enas", Avg=99.99},
                new Student(){Id=1, Name="salim", Avg=58.5}

           ];

        public delegate bool StudentDelegate(Student student);

        public static void Search(StudentDelegate studentDelegate)
        {
            foreach (Student student in Demo.students)
            {
                if(studentDelegate(student))
                    Console.WriteLine(student.Name);
            }
        }

    }
}
