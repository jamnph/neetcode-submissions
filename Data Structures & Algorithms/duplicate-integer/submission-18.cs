public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numSet = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!numSet.Add(nums[i])) return true;
        }
        return false;
    }
}