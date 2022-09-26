class Buffet{
    public List<Food> Menu;
    
    //constructor
    public Buffet(){
        Menu = new List<Food>(){
            new Food("Burger", 860, false, false),
            new Food("Pizza", 1200, false, false),
            new Food("Ramen", 790, true, false),
            new Food("Ice Cream", 600, false, true),
            new Food("Mango Habanero Wings", 820, true, true),
            new Food("Buffalo Wings", 700, true, false),
            new Food("Chocolate Chip Cookies", 200, false, true),

            new Food("Hot Sauce", -25, true, false),
            new Food("Orange Soda", 330, false, true),
            new Food("Coca Cola", 300, false, true),
            new Food("Hard Liquor", 100, true, true),
            new Food("Ginger Beer", 120, true, false),
            new Food("Seltzer Water", 0, false, false),
            new Food("Water", 0, false, false)
        };
    }
    
    public Food Serve(){
        int rand = new Random().Next(0, Menu.Count);
        //Console.WriteLine(Menu[rand]);
        return Menu[rand];
    }
}

