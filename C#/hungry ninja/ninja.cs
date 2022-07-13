class Ninja
{
    private int calorieIntake; 
    public List<Food> FoodHistory;
    
    // add a constructor
      public Ninja()
      {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
     }
        
        bool IsFull
        {
            get
            {
                return calorieIntake > 1200;
            }
        }

    
    // add a public "getter" property called "IsFull"
     
    // build out the Eat method
    public void Eat(Food item)
    {
        if(IsFull == false){
        calorieIntake = calorieIntake + item.Calories;
        FoodHistory.Add(item); 
        Console.WriteLine($"The Ninja just ate {item.Name}!");
        if(item.IsSpicy)
            Console.WriteLine($"OUCH!That {item.Name}was spicy");
            if(item.IsSweet)
            Console.WriteLine($"MMMMMMmmmmmm {item.Name} is so sweet.");
        }else{
            Console.WriteLine("Warning!This Ninja is already full");
        }
    }
        
        
    }
    
        



