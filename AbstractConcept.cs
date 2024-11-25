using System;

abstract class Student
{
    public abstract void fly();
    //public abstract void SId();
    //public abstract void Smoney()

    public void walk()
    {
        Console.WriteLine("i am walk");
    }
    class Human : Student
    {
        public override void fly()
        {
            Console.WriteLine("yes i am flying");
        }
        public static void Main()
        {
            Student h1 = new Human();
            h1.fly();
            h1.walk();
        }
    }
}
