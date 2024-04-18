using Events;


/*
    Subscriber
        1- Declare Event Handler Method
        2- Subscribe to Event
 */

var student = new Student { id = 1, name = "mahmoud", avarage = 99.9 };

student.SusbendStudent += Student_SusbendStudent;
student.SusbendStudent += method;


void method(Student student)
{
    Console.WriteLine("this is method");
}

//Handler
void Student_SusbendStudent(Student student)
{
    if (student.IsSusbended)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Student {student.name} was susbended");
        Console.ForegroundColor = ConsoleColor.White;
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Student {student.name} was unsusbended");
        Console.ForegroundColor = ConsoleColor.White;
    }

}

student.Susbend();
student.Susbend();
student.Susbend();
//student.SusbendStudent -= Student_SusbendStudent;
student.Susbend();
student.Susbend();


