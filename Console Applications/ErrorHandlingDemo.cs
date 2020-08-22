 using System; 
  
public class ErrorHandlingDemo {
  
   public static void Main() 
    { 
        int[] arr = {1, 0, 7, 2}; 
  
        try { 
  
            for (int i = 0; i < arr.Length; i++) { 
                Console.WriteLine(arr[i] / arr[i + 1]); 
            } 
        } 
  
        catch (IndexOutOfRangeException e) { 
  
            Console.WriteLine("An Exception has occurred : {0}", e.Message); 
        } 

        catch (DivideByZeroException e) { 
  
            Console.WriteLine("An Exception has occurred : {0}", e.Message); 
        } 
  
        finally { 
            for (int i = 0; i < arr.Length; i++) { 
                Console.Write(" {0}", arr[i]); 
            } 
        } 
    } 
} 