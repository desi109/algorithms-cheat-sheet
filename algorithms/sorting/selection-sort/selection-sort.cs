/** 
 *
 *  Space Complexity ->  O(1)
 *  Time Complexity  ->  O(n^2)
 *
 *
 * Step 1:    
 *         [35, 12, 29, 15, 42] 
 *         n = 5 (arr.Length)   
 *         Get the numbers 35 and 12
 *         12 < 35    so    minIdx = 12
 *         12 < 29    so    minIdx = 12
 *         12 < 15    so    minIdx = 12
 *         12 < 42    so    minIdx = 12
 *
 *         We have 35 and  minIdx = 12  so we move  35 < -- > 12 
 *         -->  [12, 35, 29, 15, 42] 
 *          
 *
 * Step 2:   
 *         [12, 35, 29, 15, 42] 
 *         Get the numbers 35 and 29
 *         29 < 35    so    minIdx = 29
 *         29 > 15    so    minIdx = 15
 *         15 < 42    so    minIdx = 15
 *
 *         We have 35 and  minIdx = 15  so we move  35 < -- > 15
 *         -->  [12, 15, 29, 35, 42] 
 *
 * Step 3:   
 *         [12, 15, 29, 35, 42]
 *         Get the numbers 29 and 35
 *         29 < 35    so    minIdx = 29
 *         29 < 42    so    minIdx = 29
 *
 *         We have minIdx = 29 and  35  so we DON'T move
 *         -->  [12, 15, 29, 35, 42] 
 *
  * Step 3:   
 *         [12, 15, 29, 35, 42]
 *         Get the numbers 35 and 42
 *         35 < 42    so    minIdx = 35
 *
 *         We have minIdx = 35 and  42  so we DON'T move
 *         -->  [12, 15, 29, 35, 42] 
 *
 */
 

    static void sort(int []arr) 
    { 
        int n = arr.Length; 
  
        for (int i = 0; i < n - 1; i++) 
        { 
        
            int minIdx = i; 
            for (int j = i + 1; j < n; j++) 
                if (arr[j] < arr[minIdx]) 
                    minIdx = j; 
  
            int temp = arr[minIdx]; 
            arr[minIdx] = arr[i]; 
            arr[i] = temp; 
        } 
    } 
