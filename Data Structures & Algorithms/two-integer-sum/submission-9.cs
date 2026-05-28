public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // naive approach
        /*
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) return [i, j];
            }
        }
        return [0, 1];
        */
        var hashmap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            hashmap[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if (hashmap.ContainsKey(diff)) {
                if (i != hashmap[diff]) return [i, hashmap[diff]];
            }
        }
        return [0, 1];

    }
}
