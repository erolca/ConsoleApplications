using System;
using System.Text;

class Sample
{
    public static void Main()
    {
        string s1 = new String(new char[] { '\u0063', '\u0301', '\u0327', '\u00BE' });
        string s1_1 = new string(new char[] { 'e', 'r', 'o', 'l','c','a' });
        string s2 = null;

        try
        {
            s2 = s1.Normalize();
            Console.WriteLine(s2.IsNormalized());
            Show("s2", s2);

            s2 = s1.Normalize(NormalizationForm.FormC);
            Console.WriteLine(s2.IsNormalized(NormalizationForm.FormC));
            Show("s2", s2);


            s2 = s1.Normalize(NormalizationForm.FormD);
            Console.WriteLine(s2.IsNormalized(NormalizationForm.FormD));
            Show("s2", s2);

            s2 = s1.Normalize(NormalizationForm.FormKC);
            Console.WriteLine(s2.IsNormalized(NormalizationForm.FormKC));
            Show("s2", s2);

            s2 = s1.Normalize(NormalizationForm.FormKD);
            Console.WriteLine(s2.IsNormalized(NormalizationForm.FormKD));
            Show("s2", s2);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void Show(string title, string s)
    {
        Console.Write("Characters in string {0} = ", title);
        foreach (short x in s.ToCharArray())
        {
            Console.Write("{0:X4} ", x);
        }
    }
}