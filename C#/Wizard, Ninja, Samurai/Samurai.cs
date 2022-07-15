class Samurai : Human
{
    public Samurai(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = 200;
    }

public override int Attack (Human target)
{
    base.Attack(target); // BASE SULMON FILLIMISHT , PSTJ KONTROLLON NESE ESHTE ME E VOGEL SE 50
    if(target.Health < 50){

    target.Health = 0;

    }
    Console.WriteLine("Shendeti i wizard tashme eshte "  + target.Health);
    return target.Health;
}
public void Meditate()
{
    Health = 200;
    Console.WriteLine("Shendeti i Samurait eshte rikuperuar " + Health);
}

}

