/** 
 *
 *  Space Complexity ->  O(1)
 *  Time Complexity  ->  O(n^2)
 *
 *
 * Step 1:    
 *         [35, 12, 29, 15, 42] 
 *         n = 5 (arr.Length)   
 *         Get the number 12
 *         12 < 35   so we move 12 -->  [12, 35, 29, 15, 42]
 *          
 *
 * Step 2:   
 *         [12, 35, 29, 15, 42]
 *         Get the number 29
 *         29 < 35  so we move 29 -->  [12, 29, 35, 15, 42]
 *         29 > 12  so we DON'T move 29 -->  [12, 29, 35, 15, 42]
 *
 *
 * Step 3:   
 *         [12, 29, 35, 15, 42]
 *         Get the number 15
 *         15 < 35  so we move 15 -->  [12, 29, 15, 35, 42]
 *         15 < 29  so we move 15 -->  [12, 15, 29, 35, 42]
 *         15 > 12  so we DON'T move 15 -->  [12, 15, 29, 35, 42]
 *
 *
 * Step 4:   
 *         [12, 15, 29, 35, 42]
 *         Get the number 42
 *         42 > 35  so we DON'T move 45 -->  [12, 15, 29, 35, 42]
 *
 */
 

static void insertSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[ j + 1] = key;
            }
