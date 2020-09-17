using System;

interface studentDetails
{
    void getStudentDetailsAndDisplay();
}

interface MarkDetails
{
    void getMarkDetailsAndDisplay();
}

class Student : studentDetails
{
    string studentName = "";
    int age = 0;
    string rollno = "";
    public void getStudentDetailsAndDisplay()
    {
        Console.WriteLine("Enter Student name:");
        studentName = Console.ReadLine();
        Console.WriteLine("Enter Student age:");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student rollno:");
        rollno = Console.ReadLine();
        Console.WriteLine("Student name: {0}", studentName);
        Console.WriteLine("Student age: " + age.ToString());
        Console.WriteLine("Student rollno: " + rollno.ToString());
    }


}

class Marks : MarkDetails
{
    int c, oracledb, java, python = 0;
    public void getMarkDetailsAndDisplay()
    {
        Console.WriteLine("Enter mark for c:");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark for oracledb:");
        oracledb = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark for java:");
        java = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter mark for python:");
        python = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("C mark: {0}", c);
        Console.WriteLine("Oracle db mark: " + oracledb.ToString());
        Console.WriteLine("Java mark: " + java.ToString());
        Console.WriteLine("Python mark: " + python.ToString());
    }
}

class Details : studentDetails, MarkDetails
{
    Student stu = new Student();
    Marks mark = new Marks();

    public void getStudentDetailsAndDisplay()
    {
        stu.getStudentDetailsAndDisplay();
    }

    public void getMarkDetailsAndDisplay()
    {
        mark.getMarkDetailsAndDisplay();
    }

}

public class InterfaceDemo
{
    public static void Main()
    {
        Student stu = new Student();
        Marks mark = new Marks();
        Details obj = new Details();
        obj.getStudentDetailsAndDisplay();
        obj.getMarkDetailsAndDisplay();
        Console.Read();
    }
}
