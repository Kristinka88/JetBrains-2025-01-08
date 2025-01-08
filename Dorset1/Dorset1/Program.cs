// See https://aka.ms/new-console-template for more information

using Dorset1;
using Console = System.Console;

Console.WriteLine("Hello, World!");

string programName = "Student Results";

Console.WriteLine(programName);

Student student1 = new Student();
student1.Name = "John Doe";
student1.Subject = "English";
student1.Score = 80;
student1.hasPassed = true;

Student student2 = new Student();
student2.Name = "Mark Free";
student2.Subject = "Math";

/*
Console.WriteLine(student1.Name);
Console.WriteLine(student2.Name);

Console.WriteLine(student1.Subject);
Console.WriteLine(student2.Subject);
*/

List<Student> students = new List<Student>();
students.Add(student1);
students.Add(student2);

foreach (Student student in students)
{
    Console.WriteLine(student.Name);
    Console.WriteLine(student.Subject);
}

foreach (Student student in students)
{
    Console.WriteLine(student);
}