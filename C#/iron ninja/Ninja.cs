using System;

namespace IronNinja
{

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


}

