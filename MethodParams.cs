using System;

public class MethodParams
{
    public static string getFullName(string firstName = "firstName",string lastName = "lastName")
    {
        return $" My Fullname is {firstName}{lastName}";
    }
    public static void Main()
    {
        Console.WriteLine(getFullName("sarath", "kumar"));
        Console.WriteLine(getFullName());
        Console.WriteLine(getFullName(firstName: "sarath", lastName: "kumar"));
    }
}
