using System;
namespace ObjectOrientedProgramming{
public abstract class Appliance
{
    public abstract void TurnOn(); // Abstract method with no implementation
}

public class WashingMachine : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Washing Machine is now ON. Ready to wash clothes.");
    }
}
public class AirConditioner : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Air Conditioner is now ON. Cooling the room.");
    }
}

class Appliances
{
  public   static void Mainappliance(string[] args)
    {
        Appliance washingMachine = new WashingMachine();
        Appliance airConditioner = new AirConditioner();

        washingMachine.TurnOn();
        airConditioner.TurnOn();
    }
}
}