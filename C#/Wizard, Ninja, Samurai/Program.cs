// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        Wizard wizard = new Wizard("Mia", 5, 25);
        Console.WriteLine(wizard.Health);
        wizard.Heal(wizard);
        Ninja ninja1  = new Ninja("Tiz", 5, 10, 50);
        ninja1.Steal(wizard);
        Samurai samurai = new Samurai("Klo", 5, 10, 50, 10);
        
        ninja1.Steal(samurai);
        samurai.Attack(ninja1);
        samurai.Meditate();


    }
}
