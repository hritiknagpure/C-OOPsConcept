using System;

class Student
{
    public void Human(int age, string name)
    {
        Console.WriteLine("My age is {0} and my name is {1}", age, name);
    }

    public void Human(string name, int rollno)
    {
        Console.WriteLine("My roll number is {0} and my name is {1}", rollno, name);
    }
}

class Program
{
    public static void Main()
    {
        Student s = new Student();
        s.Human(23, "Hritik");
        s.Human("Chirag", 54);
    }
}
