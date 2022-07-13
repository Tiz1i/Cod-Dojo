// See https://aka.ms/new-console-template for more information

class program
    {
        static void Main(string[] arg)
        {
            Human albert = new Human("albert",4,2,3,5);
            
            Human objekti2 = new Human();
           albert.Attack(objekti2);
            Console.WriteLine(objekti2.Health);
            objekti2.Attack(albert);
            Console.WriteLine(albert.Health);
           

        }
    }

class Human
{
    //Properties for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;

    //Add a constructor that takes a value to set Name, and set theremaining field to default values

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;

    }
     public Human()
    {
        Name = "flogert";
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;

    }
    public Human(string name, int fuqia, int inteligjenca, int shkathtesia, int shendeti)
    {
        Name = name;
        Strength = fuqia;
        Intelligence = inteligjenca;
        Dexterity = shkathtesia;
        Health = shendeti;
    }
    public int Attack(Human target)
    {
        int dmg = Strength * 5;
        target.Health = target.Health - dmg;
        Console.WriteLine($"{Name} attaked {target.Name} for {dmg} damage!");
        Console.WriteLine(target.Health);
        Console.WriteLine(target.Strength);
        Console.WriteLine(target.Intelligence);
        return target.Health;
    }

    
}







