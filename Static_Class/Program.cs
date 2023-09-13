// See https://aka.ms/new-console-template for more information

Console.WriteLine("Number of Worker : {0}", Worker.NumberEmployees);
Worker worker = new Worker("Berk","Besne","IK");








class Worker
{

    private static int numberEmployees;

    public static int NumberEmployees { get => numberEmployees; }
    private string Name;
    private string Surname;
    private string Department;
    static Worker() 
    {
        numberEmployees = 0;
    }
    public Worker(string name,string surname,string  departman)
    { 
        this.Name = name;
        this.Surname = surname;
        this.Department = departman;
        NumberEmployees++;
    }
}