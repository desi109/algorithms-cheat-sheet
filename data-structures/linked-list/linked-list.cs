/** 
 *  Linked List:
 *  - linear structure
 *
 */
 
 
/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Singly Linked List    
 *  Add (InsertAfter, Append)  and delete (Remove)
 *
 * 
 *             +---+------+     +---+------+     +---+------+     +---+------+
 *   head -->  | 1 | next | --> | 2 | next | --> | 5 | next | --> | 7 | next |  --> tail
 *   ----      +---+------+     +---+------+     +---+------+     +---+------+      ----
 *                            
 *
 */ 

class LinkedList
{
    class Node
    {
        int data;
        Node next;
        
        Node(int d)
        {
            data = d;
            next = null;
        }
    }
    
    Node head;
    
    
    //  add
    public void InsertAfter(Node prev_node, int new_data)
    {
         if (prev_node == null)
         {    
              Console.WriteLine("The given previous node can not be null");
              return;
         }
         
         Node new_node = new Node(new_data);
         new_node.next = prev_node.next;
         prev_node.next = new_node;  
    }
    
    
    //  add
    public void Append(int new_data)
    {
         Node new_node = new Node(new_data);
         
         if (head == null)
         {    
              head = new Node(new_data);
              return;
         }
         
         new_node.next = head;
         Node last = head;
         
         while (last.next != null)
         {
             last = lat.next;
         }
         
         last.next = new_node;
         return;
    }
    
    
    // delete
    public void Romove(int data)
    {
         Node temp = head;
         Node prev = null;
         
         if (temp != null && temp.data == data)
         {    
              head = temp.next;
              return;
         }
         
         while (temp != null && temp.data != data)
         {
               prev = temp;
               temp = temp.next;
         }   
         
         if (temp == null)
         {
              prev.next = temp.next;
         }
    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////////////////////


/**  
 *  Doubly Linked List   
 *  Read (dequeue)  and write (enqueue)
 *
 *
 *             +------+---+------+      +------+---+------+      +------+---+------+      +------+---+------+
 *   head -->  | null | 1 | next | <--> | prev | 2 | next | <--> | prev | 5 | next | <--> | prev | 7 | next |  --> tail
 *   ----      +------+---+------+      +------+---+------+      +------+---+------+      +------+---+------+      ----
 *
 */

class LinkedList
{
    class Node
    {
        int data;
        Node prev;
        Node next;
        
        Node (int d)
        {
            data = d;
        }
    }
    
    Node head;
    
    
    //  add
    public void Insert(Node prev_node, int new_data)
    {
         if (prev_node == null)
         {    
              Console.WriteLine("The given previous node can not be null");
              return;
         }
         
         Node new_node = new Node(new_data);
         new_node.next = prev_node.next;
         prev_node.next = new_node;
         new_node.prev = prev_node;
         
         if (new_node.next != null)
         {   
              new_node.next.prev = new_node;
         }  
    }
    
}
