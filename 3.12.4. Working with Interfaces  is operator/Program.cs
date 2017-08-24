using System;

interface Printable
{
    void MarginX(float factor);
    void MarginY(float factor);
}


public class Component
{
    public Component() { }
}



public class TextField : Component, Printable
{
    public TextField(string text)
    {
        this.text = text;
    }
    // implementing Printable.MarginX()
    public void MarginX(float factor)
    {
        Console.WriteLine("MarginX: {0} {1}", text, factor);
        // scale the object here.
    }

    // implementing Printable.MarginY()
    public void MarginY(float factor)
    {
        Console.WriteLine("MarginY: {0} {1}", text, factor);
        // scale the object here.
    }

    private string text;
}



class Test
{
    public static void Main()
    {
        Component[] dArray = new Component[100];

        dArray[0] = new Component();
        dArray[1] = new TextField("A");
        dArray[2] = new TextField("B");

        foreach (Component d in dArray)
        {
            if (d is Printable)
            {
                Printable scalable = (Printable)d;
                scalable.MarginX(0.1F);
                scalable.MarginY(10.0F);
            }

            // or 
           
        }
    }
}