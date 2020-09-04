using System;

class MethodParams {
    
    public static void add(int a,out int b){
        b = 50;
    }

    public static void sendGreet(ref string greet) {
        if(greet == "hi") {
            Console.WriteLine(greet+", i am sarath !");
        }
        greet = "Even though i am scoped over here i was sent as a refernce type !";
    }

    public static string getFullName(string firstName = "firstName",string lastName = "lastName")
    {
        return $" My Fullname is {firstName}{lastName}";
    }

    public static void Main() {
        int a = 50;
        int b;
        add(a,out b);
        Console.WriteLine("Addition of a and b is: {0}",a+b);
        string  greet = "hi";
        sendGreet(ref greet);
        Console.WriteLine(greet);
        Console.WriteLine(getFullName("sarath", "kumar"));
        Console.WriteLine(getFullName());
    }
}
