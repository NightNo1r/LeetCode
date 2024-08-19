/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var start = head;
        var end = head;

        for(var i = 0; i < (n - 1); i++)
        {
            end = end.next;
        }

        while(end.next?.next != null)
        {
            start = start.next;
            end = end.next;
        }

        if(end.next == null) // Corner case: Start points to element that we must to delete
        {
            return start.next;
        }

        if(start == end) // Corner case: We need to delete tail element
        {
            start.next = null;
        }

        start.next = start.next?.next;

        return head;
    }
}