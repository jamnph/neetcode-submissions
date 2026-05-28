public class Solution {
    public bool hasDuplicate(int[] nums) {
        var result = new List<int>();
        for (int i = 0; i < nums.Count(); i++) {
            if (result.Contains(nums[i]))
                return true;
            else {
                result.Add(nums[i]);
            }
        }
        return false;
    }
}
