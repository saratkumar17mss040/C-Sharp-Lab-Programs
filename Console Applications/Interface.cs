using System;

interface myOsDetails {
    void getMyOsDetails();
}

interface myFriendOsDetails {
     void getMyFriendOsDetails();
}

class myOs : myOsDetails {
    public void getMyOsDetails() {
        Console.WriteLine("Edition: Windows 10 Home Single Language");
        Console.WriteLine("Version: 1909");
    }
}

class myFriendOs : myFriendOsDetails {
     public void getMyFriendOsDetails() {
        Console.WriteLine("Edition: Windows 10 Home Multi Language");
        Console.WriteLine("Version: 1809");
    }
}

class allOs : myOsDetails, myFriendOsDetails
{
    myOs os1 = new myOs();
    myFriendOs os2 = new myFriendOs();
    
    public void getMyOsDetails(){
        os1.getMyOsDetails();
    }
    
    public void getMyFriendOsDetails() {
        os2.getMyFriendOsDetails();
    }
}

public class InterfaceDemo {
    public static void Main()
    {
        allOs os = new allOs();
        os.getMyOsDetails();
        os.getMyFriendOsDetails();
    }
}
