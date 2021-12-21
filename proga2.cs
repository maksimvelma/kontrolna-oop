using System; 
 
class laba
{ 
 
     
    static void printArray(int[] arr, int n) 
    { 
        for (int i = 0; i < n; i++) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
    } 
 
     
    static void RearrangePosNeg(int[] arr, int n) 
    { 
        int key, j; 
        for (int i = 1; i < n; i++) 
        { 
            key = arr[i]; 
 
             
            if (key > 0) 
                continue; 
 
            
            j = i - 1; 
            while (j >= 0 && arr[j] > 0) 
            { 
                arr[j + 1] = arr[j]; 
                j = j - 1; 
            } 
 
            
            arr[j + 1] = key; 
        } 
    } 
 
    
    public static void Main() 
    { 
        int[] arr = { -8, 8, -14, -5, 15, -7, 5, 3, -6 }; 
        int n = arr.Length; 
        RearrangePosNeg(arr, n); 
        printArray(arr, n); 
    } 
}