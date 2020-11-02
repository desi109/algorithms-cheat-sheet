/** 
 *  Graph:
 *  - non linear structure
 *
 */
 
 
/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Static realization of Graph - with 2-dimensional array
 *
 * 
 *        0 ----- 1 
 *        |     / | \                
 *        |    /  |  \
 *        |   /   |   2
 *        |  /    |  /
 *        | /     | /
 *        4 ----  3
 *
 *           0   1   2   3   4
 *         +---+---+---+---+---+
 *       0 | 0 | 1 | 0 | 0 | 1 |
 *         +---+---+---+---+---+
 *       1 | 1 | 0 | 1 | 1 | 1 |
 *         +---+---+---+---+---+
 *       2 | 0 | 1 | 0 | 1 | 0 |
 *         +---+---+---+---+---+
 *       3 | 0 | 1 | 1 | 0 | 1 |
 *         +---+---+---+---+---+
 *       4 | 1 | 1 | 0 | 1 | 0 |
 *         +---+---+---+---+---+
 *
 *
 */ 

class Graph
{
    private int[,] nodes;
    
    public Graph (int c)
    {
         nodes = new int[c, c];
    }
    
   
    public void Connect(int n1, int n2)
    {
         nodes [n1, n2] = nodes [n2, n1] = 1;  
    }
    
    
    public void Disconnect(int n1, int n2)
    {
         nodes [n1, n2] = nodes [n2, n1] = 0;  
    }
    
}


/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Dynamic realization of Graph - with array and linked list
 *
 *
 *        0 ----- 1 
 *        |     / | \                
 *        |    /  |  \
 *        |   /   |   2
 *        |  /    |  /
 *        | /     | /
 *        4 ----  3
 *
 *         +---+      +---+---+      +---+---+
 *       0 |   | -->  | 1 |   | -->  | 4 | / |
 *         +---+      +---+---+      +---+---+
 *
 *         +---+      +---+---+      +---+---+      +---+---+      +---+---+
 *       1 |   | -->  | 0 |   | -->  | 4 |   | -->  | 2 |   | -->  | 3 | / |
 *         +---+      +---+---+      +---+---+      +---+---+      +---+---+
 *
 *         +---+      +---+---+      +---+---+
 *       2 |   | -->  | 1 |   | -->  | 3 | / |
 *         +---+      +---+---+      +---+---+
 *
 *         +---+      +---+---+      +---+---+      +---+---+
 *       3 |   | -->  | 1 |   | -->  | 4 |   | -->  | 2 | / |
 *         +---+      +---+---+      +---+---+      +---+---+
 *
 *         +---+      +---+---+      +---+---+      +---+---+
 *       4 |   | -->  | 3 |   | -->  | 0 |   | -->  | 1 | / |
 *         +---+      +---+---+      +---+---+      +---+---+
 *
 *
 */

class Graph
{
    class Node
    {
        int n;
        Node next;
    }
    
    private Node[] nodes;
    
    public Graph (int c)
    {
          nodes = new Node[c];
    }
        
    
    public void Connect(int n1, int n2)
    {
         var newNode2 = new Node();
         newNode2.n = n2;
         newNode2.next = nodes[n1];
         nodes[n1] = newNode2;
         
         // -/- for newNode1
    }
    
    
    public void Disconnect(int n1, int n2)
    {
         if (nodes[n1] == null)
         {
             return;
         }
         
         
         if (nodes[n1].n == n2)
         {
             nodes[n1] = null;
         }
         
         var current2 = nodes[n1].next;
         var current2Prev = nodes[n1];
         
         while (current2 != null && current2.n != n2)
         { 
             current2Prev = current2;
             current2 = current.next;
         }
         
         
         if (current2 != null)
         {
             current2Prev.next = current2.next;
         }
         
         // -/- for current1     
    }
    
}
