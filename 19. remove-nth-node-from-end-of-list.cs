public class Solution 
{
    public ListNode? RemoveNthFromEnd(ListNode head, int n)
    {
        var currentNode = head;
        var possibleNode = head;

        for (var i = 1; i < n; i++)
        {
            currentNode = currentNode!.next;
        }

        if (currentNode!.next is null)
        {
            return possibleNode.next;
        }

        currentNode = currentNode.next;

        while (currentNode.next is not null)
        {
            currentNode = currentNode.next;
            possibleNode = possibleNode.next;
        }

        possibleNode.next = possibleNode.next.next;
        return head;
    }
}
