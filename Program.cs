Buffet buffet = new Buffet();
SpiceHound spiceHound = new SpiceHound();
SweetTooth sweetTooth = new SweetTooth();


Console.WriteLine("Spice Hound's Consumption History\n");
while(!spiceHound.IsFull){
    spiceHound.Consume(buffet.Serve()); 
}
spiceHound.Consume(buffet.Serve()); 
Console.WriteLine("\n***************************\n");


Console.WriteLine("Sweet Tooth's Consumption History\n");
while(!sweetTooth.IsFull){
    sweetTooth.Consume(buffet.Serve());
}
sweetTooth.Consume(buffet.Serve());
Console.WriteLine("\n***************************\n");


if(spiceHound.IsFull && sweetTooth.IsFull){
    int shCount = spiceHound.ConsumptionHistory.Count;
    int stCount = sweetTooth.ConsumptionHistory.Count;

    string SH = $"Spice Hound ate {shCount} items!";
    string ST = $"Sweet Tooth ate {stCount} items!";

    string BigEater = shCount > stCount ? "Spice Hound ate the most!" : "Sweet Tooth ate the most!";
    Console.WriteLine(SH);
    Console.WriteLine(ST);
    Console.WriteLine(BigEater);
}