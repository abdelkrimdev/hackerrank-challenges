  public static Node removeDuplicates(Node head)
  {
    //Write your code here
    var cursor = head;

    while (cursor?.next != null)
    {
      if (cursor.data == cursor.next.data)
        cursor.next = cursor.next.next;
      else
        cursor = cursor.next;
    }

    return head;
  }
