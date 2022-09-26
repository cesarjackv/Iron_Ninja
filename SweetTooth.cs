class SweetTooth : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull{
        get{
            return calorieIntake > 1500;
        }
    }

    public override void Consume(IConsumable item){
        // provide override for Consume
        
        if(IsFull){
            Console.WriteLine("Ninja is full! If they eat any more they might throw up!");
        }else{
            if(item.IsSweet){
                calorieIntake += 10;
            }
            ConsumptionHistory.Add(item);
            calorieIntake += item.Calories;
            Console.WriteLine(item.GetInfo());
        }

    }
}

