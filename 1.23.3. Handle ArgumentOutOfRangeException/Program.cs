using System;
using System.Collections;
using System.Runtime.CompilerServices;

[assembly: RuntimeCompatibility(WrapNonExceptionThrows = false)]
public class MainClass
{
    static void Main()
    {
        try
        {
            ArrayList list = new ArrayList();
            list.Add(1);

            Console.WriteLine("Item 10 = {0}", list[10]);
        }
        catch (ArgumentOutOfRangeException x)
        {
            Console.WriteLine(x);
            Console.WriteLine("ArgumentOutOfRangeException Handler");
        }
        catch (Exception x)
        {
            Console.WriteLine(x);
            Console.WriteLine("Exception Handler");
        }
        catch
        {
            Console.WriteLine("An exception I was not expecting...");
            Console.WriteLine("Unexpected Exception Handler");
        }
        finally
        {
            Console.WriteLine("Cleaning up...");
        }
    }
}