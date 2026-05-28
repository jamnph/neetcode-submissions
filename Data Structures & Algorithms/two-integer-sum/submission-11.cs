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

        //2 pass
        /* var hashmap = new Dictionary<int, int>();
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
        */

        // 1 pass
        var numsDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int diff = target - nums[i];
            if (numsDict.ContainsKey(diff)) {
                return [numsDict[diff], i];
            } else {
                numsDict[nums[i]] = i;
            }
        }
        return [-1, -1];

    }
}
