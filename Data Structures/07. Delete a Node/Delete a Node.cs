public static SinglyLinkedListNode deleteNode(SinglyLinkedListNode llist, int position)
{
    // If deleting the head (position 0)
    if (position == 0)
    {
        return llist.next; // new head
    }

    SinglyLinkedListNode current = llist;
    int index = 0;

    // Traverse to the node just before the one to delete
    while (current != null && index < position - 1)
    {
        current = current.next;
        index++;
    }

    // If current is valid and next node exists, skip the node at position
    if (current != null && current.next != null)
    {
        current.next = current.next.next;
    }

    return llist; // return original head
}
