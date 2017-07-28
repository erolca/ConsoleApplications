using System;

class MyException : ApplicationException
{
    public MyException() : base() { }
    public MyException(string str) : base(str) { }

    public override string ToString()
    {
        return Message;
    }
}

class MyDerivedException : MyException
{
    public MyDerivedException() : base() { }
    public MyDerivedException(string str) : base(str) { }

    public override string ToString()
    {
        return Message;
    }
}

class MainClass
{
    public static void Main()
    {
        for (int x = 0; x < 3; x++)
        {
            try
            {
                if (x == 0)
                    throw new MyException("Caught an MyException exception");
                else if (x == 1)
                    throw new MyDerivedException("Caught an MyDerivedException exception");
                else
                    throw new Exception();
            }
            catch (MyDerivedException exc)
            {
                // catch the exception 
                Console.WriteLine(exc);
            }
            catch (MyException exc)
            {
                // catch the exception 
                Console.WriteLine(exc);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}
