using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{

    /*
     Event Steps inside Publisher
    1- Declare Delegate
    2- Declare Event
    3- Pulish / Firing event
     */
    public class Student
    {
        public int id;
        public string name;
        public double avarage;
        public bool IsSusbended;
        public bool IsGraduated;

        public delegate void StudentDelegate(Student student);
        public event StudentDelegate SusbendStudent;

        public void Susbend()
        {
            IsSusbended = !IsSusbended;
            SusbendStudent(this);//Publish / Fire
        }

        //public void GraduateStudent()
        //{
        //    if(!IsGraduated)
        //    {
        //        IsGraduated = true;
        //        SusbendStudent(this);
        //    }
        //}
    }
}
