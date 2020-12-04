/** 
 *
 *  Space Complexity ->  O(1)
 *  Time Complexity  ->  O(n)
 *
 *
 *  1. Start from the leftmost element of arr[] and one by one 
 *     compare x with each element of arr[].
 *
 *  2. If x matches with an element, return the index.
 *
 *  3. If x doesn’t match with any of elements, return -1
 *
 *
 */
 

    public static int search(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++) 
        {
            if (arr[i] == x)
                return i;
        }
        return -1;
    }
 
    // Driver code
    public static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 10;
 
        // Function call
        int result = search(arr, x);
        if (result == -1)
            Console.WriteLine("Element is not present in array");
        else
            Console.WriteLine("Element is present at index " + result);
    }

