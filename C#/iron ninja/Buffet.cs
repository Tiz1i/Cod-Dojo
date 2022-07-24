using System;

namespace IronNinja
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>();

            Menu.Add(new Drink("Steak", 1000, true, false));
            Menu.Add(new Drink("Pizza", 1030, true, false));
            Menu.Add(new Drink("Sushi", 1050, true, false));
            Menu.Add(new Drink("Shrimp", 1080, true, false));
            Menu.Add(new Drink("Salmon", 1100, true, false));
            Menu.Add(new Drink("Burger", 1120, true, false));
            Menu.Add(new Drink("Spahgetti", 1130, true, false));



        }
    }

}