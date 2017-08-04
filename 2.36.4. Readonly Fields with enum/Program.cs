public enum ColorEnum
{
    Red,
    Blue,
    Green
}
class Color
{
    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public static Color GetPredefinedColor(ColorEnum pre)
    {
        switch (pre)
        {
            case ColorEnum.Red:
                return (new Color(255, 0, 0));

            case ColorEnum.Green:
                return (new Color(0, 255, 0));

            case ColorEnum.Blue:
                return (new Color(0, 0, 255));

            default:
                return (new Color(0, 0, 0));
        }
    }
    int red;
    int blue;
    int green;
}

class MainClass
{
    static void Main()
    {
        Color background = Color.GetPredefinedColor(ColorEnum.Blue);
       
    }
}