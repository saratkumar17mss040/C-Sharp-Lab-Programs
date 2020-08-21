using System;

public class Fundamentals
{
    public static string isIsogramOrNot(string text)
    {
        char[] arr = text.ToCharArray();
        Array.Sort(arr);
        for (int i = 0; i < text.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                return "The given string is not an isogram";
            }
        }

        return "The given string is an isogram";
    }
    public static void Main()
    {
        Console.WriteLine("Enter a string to check whether it is an isogram or not:");
        string text = Console.ReadLine();
        text = text.ToLower();
        Console.WriteLine(isIsogramOrNot(text));
        Console.ReadKey();

    }
}