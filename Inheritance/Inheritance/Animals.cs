
public class Animals : LivingThings
{
    public void swarm_with_animal()
    {
        Console.WriteLine("Animals move in swarm.");
    }
}

public class Birds:Animals
{
    public void Fly()
    {
        Console.WriteLine("Birds fly");
    }
}

public class Ducks:Animals
{
    public void Swim()
    {
        Console.WriteLine("Ducks swiming");
    }
}

