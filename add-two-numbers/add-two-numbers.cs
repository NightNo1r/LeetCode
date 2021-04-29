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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var l3 = new ListNode();
        var tl1 = l1;
        var tl2 = l2;
        var tl3 = l3;
        while(tl1.next != null && tl2.next != null)
        {
            tl3.val += (tl1.val+tl2.val);
            tl3.next = new ListNode(tl3.val/10);
            tl3.val %= 10;
            tl1 = tl1.next;
            tl2 = tl2.next;
            tl3 = tl3.next;
        }
        tl3.val += (tl1.val+tl2.val);
        if (tl1.next == null && tl2.next != null)
        {
            tl3.next = new ListNode(tl3.val/10);
            tl3.val %= 10;
            tl3 = tl3.next;
            tl2 = tl2.next;
            while(tl2.next != null)
            {
                tl3.val += tl2.val;
                tl3.next = new ListNode(tl3.val/10);
                tl3.val %= 10;
                tl2 = tl2.next;    
                tl3 = tl3.next;
            }
            tl3.val += tl2.val;
        }
        else if (tl1.next != null && tl2.next == null)
        {
            tl3.next = new ListNode(tl3.val/10);
            tl3.val %= 10;
            tl3 = tl3.next;
            tl1 = tl1.next;
            while(tl1.next != null)
            {
                tl3.val += tl1.val;
                tl3.next = new ListNode(tl3.val/10);
                tl3.val %= 10;
                tl1 = tl1.next;    
                tl3 = tl3.next;
            }
            tl3.val += tl1.val;
        }
        if(tl3.val > 9)
        {
            tl3.next = new ListNode(tl3.val/10);
            tl3.val %= 10;
        }
        return l3;
    }
}