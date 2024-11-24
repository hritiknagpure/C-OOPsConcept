using System;

class Student
{
    public void Food()
    {
        Console.WriteLine("I have food");
    }
}
class Human : Student
{
    public void Money()
    {
        Console.WriteLine("I have money");
    }
}

    class Program
    {
        public static void Main()
        {
        Human h1 = new Human();
        h1.Food();
        h1.Money();

        }
    }
