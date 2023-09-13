// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Student student1=new Student("Berk","Besne",12,15); 



class Student
{
    private string name;
    private string surname;
    private int sno;
    private int Class;

    public string Name { get => name; set => name = value; }
    public string Surname { get => surname; set => surname = value; }
    public int Sno { get => sno; set => sno = value; }
    public int Class1 { get => Class; set => Class = value; }
    public Student(string name, string surname, int class1, int sno)
    {
        Name = name;
        Surname = surname;

        Class1 = class1;
        Sno = sno;
    }
    public void StudentGetInfo()
    {
        Console.WriteLine("Student Name : {0} ", this.name);
        Console.WriteLine("Student Surname : {0}", this.surname);
        Console.WriteLine("Student No : {0}", this.Sno);
        Console.WriteLine("Student Class : {0}", this.Class);
    }
    public void UpgradeClass()
    {
        this.Class = Class + 1;
    }
    public void DownClass()
    {
        this.Class = Class - 1;

    }

}
