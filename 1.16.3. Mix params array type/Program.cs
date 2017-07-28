using System;

class MyClass
{
    public void showArgs(string msg, params int[] nums)
    {
        Console.Write(msg + ": ");

        foreach (int i in nums)
            Console.Write(i + " ");

        Console.WriteLine();
    }
}

class Person
{
    public string fullName;
    public int age;

    public Person(string n, int a)
    {
        fullName = n;
        age = a;
    }

    public void PrintInfo()
    {
        Console.WriteLine("{0} is {1} years old", fullName, age);
    }
}

class MainClass
{
 /*Methods Here */
    public static void ArrayOfInts(string msg, params int[] list)
    {
        Console.WriteLine(msg);

        for (int i = 0; i < list.Length; i++)
            Console.WriteLine(list[i]);
        Console.WriteLine();
    }

    public static void ListInts(params int[] inVals)
    {
        if (inVals != null)
            for (int i = 0; i < inVals.Length; i++)
                inVals[i] = inVals[i] * 10;
    }


    public static void ArrayOfObjects(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (list[i] is Person)
            {
                ((Person)list[i]).PrintInfo();
            }
            else
                Console.WriteLine(list[i]);
        }
        Console.WriteLine();
    }

    class Min
    {
        public int minVal(params int[] nums)
        {
            int m;

            if (nums.Length == 0)
            {
                Console.WriteLine("Error: no arguments.");
                return 0;
            }

            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < m) m = nums[i];

            return m;
        }
    }


    /*Start Here */

    public static void Main()
    {

        /*1.16.1.	Demonstrate params*/
        Min cmin = new Min();
        int min;
        int a = 10, b = 20;
        // call with two values 
        min = cmin.minVal(a, b);
        Console.WriteLine("Minimum is " + min);

        // call with 3 values 
        min = cmin.minVal(a, b, -1);
        Console.WriteLine("Minimum is " + min);

        // call with 5 values 
        min = cmin.minVal(18, 23, 3, 14, 25);
        Console.WriteLine("Minimum is " + min);

        // can call with an int array, too 
        int[] args = { 45, 67, 34, 9, 112, 8 };
        min = cmin.minVal(args);
        Console.WriteLine("Minimum is " + min);

        /* 1.16.2.Use regular parameter with a params parameter.*/

        MyClass ob = new MyClass();
       

        ob.showArgs("Here are some integers",
                    1, 2, 3, 4, 5);

        ob.showArgs("Here are two more",
                    17, 20);

        /*	1.16.3.	Mix params array type with other data types*/
        int[] intArray = new int[3] { 10, 11, 12 };
        ArrayOfInts("Here is an array of ints", intArray);
        ArrayOfInts("Enjoy these 3 ints", 1, 2, 3);
        ArrayOfInts("Take some more!", 55, 4, 983, 10432, 98, 33);



        /*1.16.4.	Array As Actual Param*/
        int[] MyArr = new int[] { 5, 6, 7 };

        ListInts(MyArr);

        foreach (int x in MyArr)
            Console.WriteLine("{0}", x);




        /*1.16.5.	Use 'params int[]'*/

        int first = 5, second = 6, third = 7;

        ListInts(first, second, third);

        Console.WriteLine("{0}, {1}, {2}", first, second, third);


        //Console Output:
        //50
        //60
        //70
        //5, 6, 7


        /*	1.16.6.	Sending in args using params keyword: object, int and string
         *	http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Sendinginargsusingparamskeywordobjectintandstring.htm
         */

        Person p = new Person("Fred", 93);
        ArrayOfObjects(7, p, "System.String");

    }
}
