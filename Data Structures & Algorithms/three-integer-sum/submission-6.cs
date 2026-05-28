public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var ans = new List<List<int>>();
        System.Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            if (nums[i] > 0) break;

            if (i > 0 && nums[i] == nums[i - 1]) continue; 
            int j = i + 1, k = nums.Length - 1;

            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum < 0) {
                    j++;
                } else if (sum > 0) {
                    k--;
                } else {
                    ans.Add(new List<int> {nums[i], nums[j], nums[k]});
                    // found a triplet for i and combo of j & k, but these j and k ccan still have duplicate
                    while (j < k && nums[k - 1] == nums[k]) k--;
                    while (j < k && nums[j + 1] == nums[j]) j++;
                    j++;
                    k--;
                }
            }

        }
        return ans.ToList();
    }
}
