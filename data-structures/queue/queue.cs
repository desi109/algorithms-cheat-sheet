/** 
 *  Queue:
 *  - linear structure
 *  - First In First Out
 *
 *            +--+--+--+--+--+
 *     7 -->  |  |6 |3 |5 |2 |
 *            +--+--+--+--+--+
 *
 *            +--+--+--+--+--+
 *            |7 |6 |3 |5 |2 |
 *            +--+--+--+--+--+
 *
 *            +--+--+--+--+--+
 *            |7 |6 |3 |5 |  |  --> 2
 *            +--+--+--+--+--+
 *
 */
 
 
/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Static Realization - with array    
 *  Read (Dequeue)  and write (Enqueue)
 *
 * 
 *     front = 5000
 *     ------------
 *                |
 *                | 
 *                0     1       2      3      4     5      6
 *            +------+------+------+------+------+------+------+
 *            |  7   |  6   |  3   |  5   |   2  |      |      |
 *            +------+------+------+------+------+------+------+
 *              5000   5004   5008   5012   5016   5020
 *                                            |
 *                                            |
 *                                            -----------                                           
 *                                            rear = 5016                 
 *
 */ 

class Queue
{
    private int front,rear, capacity;
    private int[] queue;
    
    
    public Queue(int c)
    {    
        front = rear = 0;
        capacity = c;
        queue = new int [capacity];
    }
    
    
    //  read
    public int Dequeue()
    {
         if (front == rear)
         {    
              Console.WriteLine("Queue is empty");
              return;
         }
         else
         {
               for (int i = 0; i < rear -1; i++)
               {
                   queue[i] = queue [i + 1];
               }
               
               if (rear < capacity)
               {
                   queue[rear] = 0;
               }
               
               rear--;
         }  
    }
    
    
    //  write
    public void Enqueue(int data)
    {
         if (capacity == rear)
         {    
              Console.WriteLine("Queue is full");
              return;
         }
         else
         {
               queue[rear] = data;
               rear++;
         }   
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Dynamic Realization - with linked list    
 *  Read (Dequeue)  and write (Enqueue)
 *
 *
 *    front = 4800
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
 *                                                                                                    -----------
 *                                                                                                    rear = 5000
 *
 *
 */

class Queue
{
    class Node
    {
         public int key;
         public Node next;
         
         public Node (int key)
         {
             this.key = key;
             this.next = null;
         }
    }
    
    
    Node front, rear;
   
    
    public Queue()
    {    
        this.front = this.rear = null;
    }
    
    
    //  read
    public Node Dequeue()
    {
         if (this.front == null)
         {    
              return null;
         }
         
         Node temp = this.front;
         this.front =this.front.next;
         
         if (this.front == null)
         {
               this.rear = null;
         }  
         
         return temp;
    }
    
    
    //  write
    public void Enqueue(int key)
    {
         Node temp = new Node(key);
         
         if (this.rear == null)
         {    
              this.front = this.rear = temp;
              return;
         }
         
         this.rear.next = temp;
         this.rear = temp;
    }
}



