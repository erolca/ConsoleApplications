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
    }

    // implementing Printable.MarginY()
    public void MarginY(float factor)
    {
        Console.WriteLine("MarginY: {0} {1}", text, factor);
    }

    private string text;
}

class MainClass
{
    public static void Main()
    {
        Component[] dArray = new Component[100];

        dArray[0] = new Component();
        dArray[1] = new TextField("A");
        dArray[2] = new TextField("B");

        foreach (Component d in dArray)
        {
            Printable scalable = d as Printable;
            if (scalable != null)
            {
                scalable.MarginX(0.1F);
                scalable.MarginY(10.0F);
            }
        }
    }
}