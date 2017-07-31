using System;
using System.Runtime.Serialization;

[Serializable]
public sealed class MyException : Exception
{
    private string stringInfo;
    private bool booleanInfo;

    public MyException() : base() { }
    public MyException(string message) : base(message) { }
    public MyException(string message, Exception inner) : base(message, inner) { }

    private MyException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
        stringInfo = info.GetString("StringInfo");
        booleanInfo = info.GetBoolean("BooleanInfo");
    }

    public MyException(string message, string stringInfo, bool booleanInfo) : this(message)
    {
        this.stringInfo = stringInfo;
        this.booleanInfo = booleanInfo;
    }

    public MyException(string message, Exception inner, string stringInfo, bool booleanInfo) : this(message, inner)
    {
        this.stringInfo = stringInfo;
        this.booleanInfo = booleanInfo;
    }

    public string StringInfo
    {
        get { return stringInfo; }
    }

    public bool BooleanInfo
    {
        get { return booleanInfo; }
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("StringInfo", stringInfo);
        info.AddValue("BooleanInfo", booleanInfo);

        base.GetObjectData(info, context);
    }

    public override string Message
    {
        get
        {
            string message = base.Message;
            if (stringInfo != null)
            {
                message += Environment.NewLine + stringInfo + " = " + booleanInfo;
            }
            return message;
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        try
        {
            throw new MyException("Some error", "SomeCustomMessage", true);
        }
        catch (MyException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.BooleanInfo);
            Console.WriteLine(ex.StringInfo);
        }
    }
}