



//public: The type or member can be accessed by any other code in the same assembly or another assembly that references it. The accessibility level of public members of a type is controlled by the accessibility level of the type itself.

//private: The type or member can be accessed only by code in the same class or struct.

//protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.

//internal: The type or member can be accessed by any code in the same assembly, but not from another assembly. In other words, internal types or members can be accessed from code that is part of the same compilation.

//protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.

//private protected: The type or member can be accessed by types derived from the class that are declared within its containing assembly.
Worker worker1 = new Worker("ali","Ahmet",53455,"Salesman");
worker1.WokerInfo();

Worker woker2 = new Worker();
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
    public Worker(string name,string surname,int no, string description)
    {
        this.Name = name;   
        this.Surname = surname;
        this.No = no;
        this.Description = description;
    }
    public void WorkerInfo()
    {
        Console.WriteLine("Woker Name: {0}", Name);
        Console.WriteLine("Worker Surname: {0}",Surname);
        Console.WriteLine("Worker No:{0} ",No);
        Console.WriteLine("Worker Description:{0}", Description);
    }
}