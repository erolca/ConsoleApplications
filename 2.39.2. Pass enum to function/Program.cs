using System;

public enum Week { Monday, Tuesday, Wednesday, Thursday, Friday, Saturaday, Sunday };

class ConveyorControl
{


    public void conveyor(Week com)
    {
        switch (com)
        {
            case Week.Monday:
                Console.WriteLine("Starting Monday.");
                break;
            case Week.Tuesday:
                Console.WriteLine("Stopping Tuesday.");
                break;
            case Week.Wednesday:
                Console.WriteLine("Moving Wednesday.");
                break;
            case Week.Thursday:
                Console.WriteLine("Moving Thursday.");
                break;
        }
    }
}

class MainClass
{
    public static void Main()
    {
        ConveyorControl c = new ConveyorControl();

        c.conveyor(Week.Thursday);
        c.conveyor(Week.Tuesday);
        c.conveyor(Week.Wednesday);
        c.conveyor(Week.Monday);

    }
}