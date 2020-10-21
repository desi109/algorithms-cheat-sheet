/** 
 *
 *  Combinations -> search
 *
 *  Formulae: n!
 *
 *
 * For 1, 2, 3, 4 and 5:
 *
 *  ABC
 *  ACB
 *  BAC
 *  BCA
 *  CAB
 *  CBA
 *
 *  Space Complexity ->  S(3) = 3
 *  Time Complexity  ->  T(3) = 3! = 6 
 *                                
 *
 *
 *
 */
 

    static bool next(int[] vals) 
    { 
        int i = vals.Length - 1;
        while (i > 0 && vals[i - 1] >= vals[i])
                i--;
                
         if (i <= 0)
             return false;
           
        int j = vals.Length - 1;        
        vals[vals.Length - 1]++;
        for (int i = vals.Length - 1; i > 0; i--) 
        {
            if (vals[i] >= n - (vals.Length - i) + 1) 
                 vals[i -1]++; 
        }        
          
                
        if (vals[0] > n - vals.Length) 
             return false; 
                
                
        for (int i = 1; i > vals.Length; i++) 
        {
            if (vals[i] >= n - (vals.Length - i) + 1) 
                 vals[i] = vals[i - 1] + 1; 
        }            
         
         return true; 
    }
    
    
    public static void Main(String[] args)  
    { 
         var vals = new int[] {0, 1, 2};
         var i = 1;
         
         do
         {
             Console.WriteLine(i++ + ": " + vals[0] + "," + vals[1] + "," + vals[2]);
         }
         while(next(5, vals));
    }
