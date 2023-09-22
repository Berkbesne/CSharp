namespace  Inheritance{ 
public class Plants : LivingThings
{
    public void photosynthesis() {
        Console.WriteLine("Plants perform photosynthesis");
    }

}
public class Seeded_Plants: Plants{
    public void Seeding() 
    {
        Console.WriteLine("Seed plants reproduce by seed ");
    }
}
public class Seedless_Plants: Plants
{
    public void ReproductionBySpores()
    {
        Console.WriteLine("Seedless plants reproduce by spores ");
    }
}
}

