Worker woker1 = new Worker();
woker1.Name = "Tuncer Berk";
woker1.Surname = "Besne";
woker1.No = 118;
woker1.Description = "Salesman";
woker1.WorkerInfo();
Console.WriteLine("*******");

class Worker{
    public string Name;
    public string Surname;
    public int No;
    public string Description;
    public void WorkerInfo()
    {
        Console.WriteLine("Woker Name: {0}", Name);
        Console.WriteLine("Worker Surname: {0}",Surname);
        Console.WriteLine("Worker No:{0} ",No);
        Console.WriteLine("Worker Description:{0}", Description);
    }
}