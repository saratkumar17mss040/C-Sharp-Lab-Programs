using System;
public class DelegateDemo {
    
   public delegate void mulNum(int a,int b);
   public delegate void divNum(int a,int b);
    
   public void mul(int a = 0, int b = 0) {
       Console.WriteLine("a + b = {0}", a*b);
   } 
   
   public static void div(int a = 0, int b = 0) {
       Console.WriteLine("a - b = {0}", a/b);
   }
   
   public static void Main() {
    Console.WriteLine("DelegateDemo");
    DelegateDemo d = new DelegateDemo();
    mulNum mulDelegate = new mulNum(d.mul);
    divNum divDelegate = new divNum(div);
    mulDelegate(5,5);
    divDelegate(5,5);
    mulDelegate.Invoke(5,5);
    divDelegate.Invoke(5,5);
  }
}