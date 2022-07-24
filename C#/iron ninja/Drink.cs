using System;

namespace IronNinja
{
    public class Drink : IConsumable
    {

        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsSweet { get; set; }

        //Implement a GetInfo Method
        public string GetInfo()
        {
            return $"{ Name} (Food).Calories: { Calories}. Spicy ?: { IsSpicy}, Sweet ?: { IsSweet}";
        }

        // Add a constructor method
        public Drink(String name, int Calories, bool sicy, bool Sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = Sweet;

        }
    }




}