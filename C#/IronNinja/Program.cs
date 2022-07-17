// See https://aka.ms/new-console-template for more information
public interface IConsumable
{
    string Name { get; set; }
    int Calories { get; set; }
    bool IsSpicy { get; set; }
    bool IsSweet { get; set; }
    string GetInfo();
}
public class Food : IConsumable
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public bool IsSpicy { get; set; }
    public bool IsSweet { get; set; }
    public string GetInfo()
    {
        return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet ?: {IsSweet}";
    }
    public Food(string name, int calories, bool spicy, bool sweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
    }
}
public class Drink : IConsumable
{
    public string Name { get; set; }
    public int Calories { get; set; }
    public bool IsSpicy { get; set; }
    public bool IsSweet { get; set; }
    public string GetInfo()
    {
        return $"{Name} (Food). Calories: {Calories}. Spicy?: {IsSpicy}, Sweet ?: {IsSweet} ";
    }
    public Drink(string name, int calories, bool spicy, bool sweet)
    {
        Name = name;
        Calories = calories;
        IsSpicy = spicy;
        IsSweet = sweet;
    }
}
public abstract class Ninja
{
    protected int calorieIntake;
    public List<IConsumable> ConsumptionHistory;
    public Ninja()
    {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public abstract bool IsFull { get; }
    public abstract void Consume(IConsumable item);
}
public class SweetTooth : Ninja
{
    public override bool IsFull
    {
        get
        {
            if (calorieIntake > 1500)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            if (item.IsSweet)
                calorieIntake += (item.Calories + 10);
            else
                calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else
            Console.WriteLine("SweetTooth is full and cannot eat anymore");
    }
}
class SpiceHound : Ninja
{
    public override bool IsFull
    {
        get
        {
            if (calorieIntake > 1200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public override void Consume(IConsumable item)
    {
        if (!IsFull)
        {
            if (item.IsSpicy)
                calorieIntake += (item.Calories - 5);
            else
                calorieIntake += item.Calories;
            ConsumptionHistory.Add(item);
            item.GetInfo();
        }
        else
            Console.WriteLine("SpiceHound is full and cannot eat anymore");
    }
}
public class Buffet
{
    public List<IConsumable> Menu;
    //constructor
    public Buffet()
    {
        Menu = new List<IConsumable>();
        Menu.Add(new Drink("Steak", 1000, true, false));
        Menu.Add(new Drink("Pizza", 1010, false, true));
        Menu.Add(new Drink("Sushi", 1020, true, false));
        Menu.Add(new Drink("Shrimp", 1030, true, false));
        Menu.Add(new Drink("Salmon", 1040, false, true));
        Menu.Add(new Drink("Burger", 1050, true, false));
        Menu.Add(new Drink("Spahgetti", 1060, true, false));
    }
}
class program
{
    static void Main(string[] arg)
    {
        Buffet buffet1 = new Buffet();
        SpiceHound sh1 = new SpiceHound();
        SweetTooth st1 = new SweetTooth();

        Random rnd = new Random();
        int rand = rnd.Next(0, 7);
        int rand1 = rnd.Next(0, 7);
        sh1.Consume(buffet1.Menu[rnd.Next(0, 7)]);
        sh1.Consume(buffet1.Menu[rnd.Next(0, 7)]);
        sh1.Consume(buffet1.Menu[rnd.Next(0, 7)]);
        st1.Consume(buffet1.Menu[rnd.Next(0, 7)]);
        if (sh1.ConsumptionHistory.Count > st1.ConsumptionHistory.Count)
        {
            int cons = sh1.ConsumptionHistory.Count - st1.ConsumptionHistory.Count;
            Console.WriteLine($"SweetTooth consumed {cons} more");
        }
        else if (sh1.ConsumptionHistory.Count == st1.ConsumptionHistory.Count)
        {
            st1.Consume(buffet1.Menu[rnd.Next(0, 7)]);
            Console.WriteLine($"SweetTooth and SpiceHound consumed bot {sh1.ConsumptionHistory.Count} ");
        }
        else
        {
            int con = st1.ConsumptionHistory.Countsh1.ConsumptionHistory.Count;
            Console.WriteLine($"SpiceHound consumed {con} more");
        }
    }
}
