class Student
{
    private string name1;
        private int rollno;
        private int age;

  //for setter
        public void accept(string name1,int rollno,int age)
    {
        this.name1 = name1;
        this.rollno = rollno;
        this.age = age;
    }

  //getter
    public void display() {
        Console.WriteLine("My name is + and rollno is {1} and age is {2}", name1, rollno, age);
    }

    public static void Main()
    {
        Student s = new Student();
        s.accept("hritik", 65, 24);
        s.display();
        Student s1 = new Student();
        s1.accept("chirag", 66, 23);
        s.display();
    }
}
