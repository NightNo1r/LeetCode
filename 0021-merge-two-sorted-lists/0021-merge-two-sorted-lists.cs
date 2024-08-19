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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if(list1 is null)
        {
            return list2;
        }

        if(list2 is null)
        {
            return list1;
        }

        ListNode mergedHead;
        if(list1.val < list2.val)
        {
            mergedHead = list1;
            list1 = list1.next;
        }
        else
        {
            mergedHead = list2;
            list2 = list2.next;
        }

        var merged = mergedHead;
        while(list1 is not null &&
              list2 is not null)
        {
            if(list1.val < list2.val)
            {
                merged.next = list1;
                list1 = list1.next;
            }
            else
            {
                merged.next = list2;
                list2 = list2.next;
            }

            merged = merged.next;
        }

        merged.next = list1 ?? list2;

        return mergedHead;
    }
}