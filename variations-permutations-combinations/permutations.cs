/** 
 *
 *  Combinations -> search
 *
 *  Formulae: n!
 *
 * !!! NO repetition
 * !!! order matters
 *
 * For 0, 1, 2 :
 *
 *  123
 *  132
 *  213
 *  231
 *  312
 *  321
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
        while(vals[j] <= vals[i - 1])    
               j--;
                  
        swap(ref vals[i - 1], ref vals[j]);
        
        j =vals.Length - 1;
        while(i < j)
        {
             swap(ref vals[i], ref vals[j]);
             i++;
             j--;
        }
         
         return true; 
    }
    
    
    
    static void swap(ref int num1, ref int num2)
    {
        int num3;
         
        num3 = num1;
        num1 = num2;
        num2 = num3;
    }
    
    
    public static void Main(String[] args)  
    { 
         var vals = new int[] {1, 2, 3};
         var i = 1;
         
         do
         {
             Console.WriteLine(i++ + ": " + vals[0] + "," + vals[1] + "," + vals[2]);
         }
         while(next(vals));
    }
