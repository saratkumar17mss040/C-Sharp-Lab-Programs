using System;
using System.Collections;

public class ArrayListDemo
{

    public static void Main()
    {
        Console.WriteLine("Enter a num for multiplying:");
        string strMultiplier = Console.ReadLine();
        int multiplier = Convert.ToInt32(strMultiplier);
        Console.WriteLine("Enter number of times the multiplier should multiple starting from 1:");
        string strNumberOfTimes = Console.ReadLine();
        int numberOfTimes = Convert.ToInt32(strNumberOfTimes);
        ArrayList myList = new ArrayList();

        for (int i = 1; i <= numberOfTimes; i++)
        {
            myList.Add(i * multiplier);
        }
        
         myList.Add(100 * 100);
         myList.RemoveRange(0,4);

        foreach(int i in myList)
        { 
            Console.WriteLine(i); 
        } 
      
    }
}