class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Cake", 1000, false, true),
            new Food("Carrot", 500, false, false),
            new Food("Mango", 400, false, false),
            new Food("CheesCake", 1000, false, true),
            new Food("Pepperoni", 1000, true, false),
            new Food("Chocolate", 1000, false, true),
            new Food("Salce", 700, true, false)
        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        Food mexican = Menu[rand.Next(Menu.Count)];
        Console.WriteLine(mexican);
        return mexican;
    }
   
}