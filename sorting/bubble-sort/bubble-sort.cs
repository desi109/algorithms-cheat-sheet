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
 *         35 > 12    so    swap  35 < -- > 12      [12, 35, 29, 15, 42]
 *         35 > 29    so    swap  35 < -- > 29      [12, 29, 35, 15, 42]
 *         35 > 15    so    swap  35 < -- > 29      [12, 29, 15, 35, 42]
 *         35 < 42    so    DON'T swp and stop      
 *
 *         -->  [12, 29, 15, 35, 42]
 *          
 *
 * Step 2:   
 *         [12, 29, 15, 35, 42]
 *         Get the numbers 12 and 29
 *         12 < 29    so    DON'T swp and stop      
 *
 *         -->  [12, 29, 15, 35, 42]
 *         
 *
 *
 * Step 3:   
 *         [12, 29, 15, 35, 42]
 *         Get the numbers 29 and 15
 *         29 > 15    so    swap  29 < -- > 15      [12, 15, 29, 35, 42]
 *         29 < 35    so    DON'T swp and stop  
 *
 *         -->  [12, 15, 29, 35, 42]
 *
 *
 *
  * Step 4:   
 *         [12, 15, 29, 35, 42]
 *         Get the numbers 35 and 42
 *         35 < 42    so    DON'T swp and stop
 *
 *         -->  [12, 15, 29, 35, 42] 
 *
 */
 

    static void bubbleSort(int []arr) 
    { 
        int n = arr.Length; 
        for (int i = 0; i < n - 1; i++) 
            for (int j = 0; j < n - i - 1; j++) 
                if (arr[j] > arr[j + 1]) 
                { 
                    // swap temp and arr[i] 
                    int temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                } 
    } 
