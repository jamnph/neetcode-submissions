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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // some trivial result
        if (list1 == null) {
            if (list2 != null) return list2;
            else return null;
        }
        if (list2 == null) {
            if (list1 != null) return list1;
            else return null;
        }

        ListNode result = new ListNode(), iter = result;

        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                iter.next = list1;
                list1 = list1.next;
            } else {
                iter.next = list2;
                list2 = list2.next;
            }
            iter = iter.next;
        }

        if (list1 == null) {
            iter.next = list2;
        } else {
            iter.next = list1;
        }

        return result.next;
    }
}