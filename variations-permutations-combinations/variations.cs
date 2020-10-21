/** 
 *
 *  Variations with repetitions -> search
 *  Formulae: (n^k)
 *
 *
 * For 0, 1 and 2:
 *
 *  000   100   200
 *  001   101   201
 *  002   102   202
 *  010   110   210
 *  011   111   211
 *  012   112   212
 *  020   120   220
 *  021   121   221
 *  022   122   222
 *
 *
 *  Space Complexity ->  S(3) = 3
 *  Time Complexity  ->  T(3;3) = (n^k) = 3^3 = 27
 *
 *
 *
 */
 

    static bool next(int n, int[] vals) 
    { 
        var k = vals.Length; 
        
        vals[k - 1]++;
        for (int i = k - 1; i > 0; i--) 
        {
            if (vals[i] >= n) 
                { 
                    vals[i] = 0; 
                    vals[i -1]++; 
                }
         }
         return vals[0] < n; 
    }
    
    
    public static void Main(String[] args)  
    { 
         var vals = new int[3];
         var i = 1;
         
         do
         {
             Console.WriteLine(i++ + ": " + vals[0] + "," + vals[1] + "," + vals[2]);
         }
         while(next(3, vals));
    }
