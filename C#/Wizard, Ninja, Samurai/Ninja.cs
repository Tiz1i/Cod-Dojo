public class Ninja : Human
{
    public Ninja(string name, int str, int intel, int hp) : base(175)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Health = hp;

    }

    // Build Attack method
     public override int Attack(Human target)
    {
        Random rand = new Random();
        int rnd = rand.Next(1,6);
        if(rnd == 1){
            target.Health -= 10;
        }
        Console.WriteLine(target.Health);
        return target.Health;
    }

    public int Steal(Human target)
    {
        target.Health -= 5;// ai qe sulmohet, ne kete rast wizard
        Health +=5; // sulmuesi pra ia mori wizardit 5 dhe ia shtoi vetes 5 pra ninjas
        Console.WriteLine(target.Health);
        Console.WriteLine(Health);
        return target.Health;
    }
}
