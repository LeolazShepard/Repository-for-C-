using System;
delegate string StrMod(string str);
class DelegateTest
{
    static string ReplaceSpaces(string s)
    {
        Console.WriteLine("Заміна пробілів дефісами.");
        return s.Replace(' ', '-');
    }
    static string RemoveSpaces(string s)
    {
        string temp = "";
        int i;
        Console.WriteLine("Видалення пробілів.");
        for (i = 0; i < s.Length; i++)
            if (s[i] != ' ') temp += s[i];
        return temp;
    }
    static string Reverse(string s)
    {
        string temp = "";
        int i, j;
        Console.WriteLine("Інвертування рядка.");
        for (j = 0, i = s.Length - 1; i >= 0; i--, j++)
            temp += s[i];
        return temp;
    }
    static void Main()
    {
        StrMod strOp = new StrMod(ReplaceSpaces);
        string str;
        str = strOp("Це простий тест.");
        Console.WriteLine("Результуючий рядок: " + str);
        Console.WriteLine();
        strOp = new StrMod(RemoveSpaces);
        str = strOp("Це простий тест.");
        Console.WriteLine("Результуючий рядок: " + str);
        Console.WriteLine();
        strOp = new StrMod(Reverse);
        str = strOp("Це простий тест.");
        Console.WriteLine("Результуючий рядок: " + str);
    }
}