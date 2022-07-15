public class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }



    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
    public Human(int intel, int hp)//this is for wizard constructor, inheritance
    {
        Intelligence = intel;
        Health = hp;
    }

    public Human(int dex)//this is for ninja constructor, inheritance
    {
        Dexterity = dex;

    }
    public Human()
    {
        
    }
    public virtual int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
}
