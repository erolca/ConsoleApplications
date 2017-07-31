using System;
using System.Reflection;
using System.Runtime.Serialization;

[assembly: AssemblyVersion("1.1.0.0")]
[assembly: AssemblyCultureAttribute("")]


[Serializable]
public class CustomException : Exception
{

    public CustomException() : base("custom exception", null)
    {
        prop_Time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
    }

    protected CustomException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
        prop_Time = info.GetString("Time");
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Time", prop_Time, typeof(string));
        base.GetObjectData(info, context);
    }

    protected string prop_Time = null;
    public string Time
    {
        get
        {
            return prop_Time;
        }
    }
}