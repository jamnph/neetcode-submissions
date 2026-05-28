public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashTable = new HashSet<int>();
        for (int i = 0; i < nums.Count(); i++) {
            if (hashTable.Contains(nums[i]))
                return true;
            else
                hashTable.Add(nums[i]);
        }
        return false;
    }
}
