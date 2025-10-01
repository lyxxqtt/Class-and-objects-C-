using System;

class Student
{
    string Name;
    int Age;
    string Grade;

    public void SetDetails(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age + ", Grade: " + Grade);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.SetDetails("lyx", 17, "Grade 12");

        Student student2 = new Student();
        student2.SetDetails("Tino", 17, "Grade 12");
    }
}
