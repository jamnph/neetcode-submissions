public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;

        // matrix is sorted, mid row
        // each row is binary search

        int lower = 0, upper = m - 1, midRow;
        while (lower <= upper) {
            midRow = (lower + upper) / 2;
            // the whole matrix sorted so check if
            // a/ target is in lower row than midRow
            // b/ target is in midRow
            // c/ target is in high row than midRow
            // binary search subrouting in correct row
            if (target < matrix[midRow][0]) {
                upper = midRow - 1;
            } else if (target > matrix[midRow][n - 1]) {
                lower = midRow + 1;
            } else { //  target is in midRow
                return RowBinarySearch(matrix[midRow], target);
            }
        }
        return false;
    }

    public bool RowBinarySearch(int[] nums, int target) {
        int l = 0, r = nums.Length - 1, mid;

        while (l <= r ) {
            mid = (l + r) / 2;
            if (nums[mid] < target) {
                l = mid + 1;
            } else if (nums[mid] > target) {
                r = mid - 1;
            } else return true;
        }
        return false;
    }
}
