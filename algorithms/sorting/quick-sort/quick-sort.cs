/** 
 *
 *  Space Complexity ->  O(log n)
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
 

    static int partition(int []arr, int low, 
                                   int high) 
    { 
        int pivot = arr[high];  
          
        // index of smaller element 
        int i = (low - 1);  
        for (int j = low; j < high; j++) 
        { 
            // If current element is smaller  
            // than the pivot 
            if (arr[j] < pivot) 
            { 
                i++; 
  
                // swap arr[i] and arr[j] 
                int temp = arr[i]; 
                arr[i] = arr[j]; 
                arr[j] = temp; 
            } 
        } 
  
        // swap arr[i+1] and arr[high] (or pivot) 
        int temp1 = arr[i+1]; 
        arr[i+1] = arr[high]; 
        arr[high] = temp1; 
  
        return i+1; 
    } 
  
  
    /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
    low --> Starting index, 
    high --> Ending index */
    static void quickSort(int []arr, int low, int high) 
    { 
        if (low < high) 
        { 
              
            /* pi is partitioning index, arr[pi] is  
            now at right place */
            int pi = partition(arr, low, high); 
  
            // Recursively sort elements before 
            // partition and after partition 
            quickSort(arr, low, pi-1); 
            quickSort(arr, pi+1, high); 
        } 
    } 
  
    // A utility function to print array of size n 
    static void printArray(int []arr, int n) 
    { 
        for (int i = 0; i < n; ++i) 
            Console.Write(arr[i] + " "); 
              
        Console.WriteLine(); 
    } 
