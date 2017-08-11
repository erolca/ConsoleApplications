using System;
using System.Collections;

enum MyEnum
{
    A, B, C, D
}

class Coffee
{
    private BitArray ingredientFlags = new BitArray(8);
    
    public void AddIngredient(MyEnum type)
    {
        ingredientFlags[(int)type] = true;
    }

    public void ListMyEnum()
    {
        for (int i = 0; i < ingredientFlags.Count; i++)
        {
            if (ingredientFlags[i])
                Console.WriteLine("-" + Enum.GetName(typeof(MyEnum), i));
        }
    }

    public void Drink()
    {
        ingredientFlags.Xor(ingredientFlags);
        ListMyEnum();
    }
}

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        Coffee java = new Coffee();

        java.AddIngredient(MyEnum.B);
        java.AddIngredient(MyEnum.C);
        java.AddIngredient(MyEnum.A);

        java.ListMyEnum();

        java.Drink();
    }
}