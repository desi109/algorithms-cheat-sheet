/** 
 *  Stack:
 *  - linear structure
 *  - Last In First Out
 *
 *
 *            +--+     +--+    +--+
 *     7 -->  |  |     |7 |    |  |  --> 7
 *            +--+     +--+    +--+
 *            |6 |     |6 |    |6 |
 *            +--+     +--+    +--+
 *            |3 |     |3 |    |3 |
 *            +--+     +--+    +--+
 *            |5 |     |5 |    |5 |
 *            +--+     +--+    +--+
 *            |2 |     |2 |    |2 |
 *            +--+     +--+    +--+
 *
 *
 */
 
 
/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**
 *  Static Realization - with array    
 *  Constant complexity when read (Pop)  and write (Push)
 *
 *
 *
 *     front = 5000
 *     ------------
 *                |
 *                |                  
 *            +------+
 *      5000  |  7   | 0
 *            +------+
 *      5004  |  6   | 1
 *            +------+
 *      5008  |  3   | 2
 *            +------+
 *      5012  |  5   | 3
 *            +------+
 *      5016  |  2   | 4
 *            +------+
 *               
 *                                                  
 *
 */
 
class Stack
{
    const int MAX = 1000;
    int top;
    int [] stack = new int[MAX];
    
    
    public Stack()
    {    
        top = -1;
    }
    
    
    //  read
    public int Pop()
    {
         if (top < 0)
         {    
              Console.WriteLine("Stack Underflow");
              return 0;
         }
         else
         {
               int value = stack[top--];
               return value;
         }  
    }
    
    
    //  write
    public bool Push(int data)
    {
         if (top >= MAX)
         {    
              Console.WriteLine("Stack Overflow");
              return false;
         }
         else
         {
               stack[++top] = data;
               return true;
         }   
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////

/**
 *      Dynamic Realization - with linked list
 *      Read (Pop)  and write (Push)
 *
 *
 *    top = 4800
 *    ----------
 *
 *           data   next     +------>--------+
 *         +------+-----+    |               |       +------->-------+
 *         |  44  |4800 |----+     +------+-----+    |               |        +------->-------+
 *         +------+-----+          |  33  |4900 |----+      +------+-----+    |               |
 *         | 4700 |                +------+-----+           |  22  |5000 |----+      +------+-----+
 *         +------+                | 4800 |                 +------+-----+           | 11   | nul |
 *                                 +------+                 | 4900 |                 +------+-----+
 *                                                          +------+                 | 5000 |
 *                                                                                   +------+
 *   
 *               
 */
 

class Stack
{
    private class Node
    {
        puvlic int data;
        public Node link;
    }
    
    Node top;
    
    public Stack()
    {    
        this.top = null;
    }
    
    
    //  read
    public void Pop()
    {
         if (top == null)
         {    
              Console.WriteLine("Stack Underflow");
              return;
         }
         
         top = (top).link;
    }
    
    
    //  write
    public void Push(int x)
    {
         Node temp = new Node();
         
         if (temp == null)
         {    
              Console.WriteLine("Stack Overflow");
              return;
         }
         
         temp.data = x;
         temp.link = top;
         top = temp;
    }
}


