using System;
using System.Threading;
using System.Windows.Forms;
using Payroll;

public class BlockLeftMouseButtonMessageFilter : IMessageFilter
{
    const int WM_LBUTTONDOWN = 0x201;

    public bool PreFilterMessage(ref Message m)
    {
        if (m.Msg == WM_LBUTTONDOWN)
        {
            Exception LeftButtonDownException;

            LeftButtonDownException = new Exception("The left mouse button was pressed.");
            Application.OnThreadException(LeftButtonDownException);
            return true;
        }
        return false;
    }
}

public class ApplicationEventHandlerClass
{
    public void OnThreadException(object sender, ThreadExceptionEventArgs e)
    {
        Exception LeftButtonDownException;

        LeftButtonDownException = e.Exception;
        Console.WriteLine(LeftButtonDownException.Message);
    }
}

public class MainForm : Form
{
    public static void Main()
    {
        ApplicationEventHandlerClass AppEvents = new ApplicationEventHandlerClass();
        MainForm MyForm = new MainForm();
        BlockLeftMouseButtonMessageFilter MsgFilter = new BlockLeftMouseButtonMessageFilter();

        Application.AddMessageFilter(MsgFilter);
        Application.ThreadException += new ThreadExceptionEventHandler(AppEvents.OnThreadException);

        Employee newEmploye = new Employee(15,"Jack Deniels");

        Application.Run(MyForm);
    }

    public MainForm()
    {
        Text = "Application Exception Test";
    }
}


namespace DocumentationCommentsExample
{
    /// <summary>
    /// A documentation sample - the short description goes here
    /// </summary>
    /// <remarks>Where a longer description would go</remarks>
    class ClassExample
    {
        /// <summary>
        /// A member variable
        /// </summary>
        private string m_str;


        /// <summary>
        /// A property example
        /// </summary>
        /// <remarks>
        /// You would put a more in depth description inside remarks tags
        /// </remarks>
        public string PropertyExample
        {
            get
            {
                return m_str;
            }
        }

        /// <summary>
        /// A method example
        /// </summary>
        /// <param name="val">a new value to be saved</param>
        /// <returns>the length of the string</returns>
        public int MethodExample(string val)
        {
            m_str = val;
            return val.Length;
        }


    }
}


namespace Payroll
{

    /// <summary> 
    /// Document for Employee class
    /// See a cross reference <see cref="String">string</see>
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Comment for the constructor
        /// <paramref name="name">name2</paramref> is a string.
        /// </summary>
        /// <param name="id">Employee id number</param>
        /// <param name="name">Employee Name</param>
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Comments for another constructor
        /// </summary>
        /// <remarks>
        /// <seealso cref="Employee(int, string)">Employee(int, string)</seealso>
        /// </remarks>
        public Employee()
        {
            id = -1;
            name = null;
        }
        int id;
        string name;
    }
}