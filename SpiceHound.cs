class SpiceHound : Ninja
{
    // provide override for IsFull (Full at 1500 Calories)
    public override bool IsFull{
        get{
            return calorieIntake > 1200;
        }
    }

    public override void Consume(IConsumable item){
        // provide override for Consume
        
        if(IsFull){
            Console.WriteLine("Ninja is full! Any more food will give their butt enough rocket fuel to fly to the moon!!!");
        }else{
            if(item.IsSpicy){
                calorieIntake -= 5;
            }
            ConsumptionHistory.Add(item);
            calorieIntake += item.Calories;
            Console.WriteLine(item.GetInfo());
        }
        
    }
}

