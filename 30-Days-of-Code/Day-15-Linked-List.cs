public static Node insert(Node head,int data)
{
    //Complete this method
    if (head == null) return new Node(data);
    else
    {
      Node tail = head;

      while (tail.next != null) tail = tail.next;

      tail.next = new Node(data);

      return head;
    }
  }
