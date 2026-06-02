public class Solution {
    public int[] PlusOne(int[] digits) {
        int[] result = new int[digits.Length + 1];
        int carry = 1;
        for (int i = digits.Length - 1; i >= 0; i--) {
            int temp = digits[i] + carry;
            if (temp < 10) {
                carry = 0;
                result[i + 1] = temp;
            }
        }
        
        if (carry == 1) {
            result[0] = 1;
            return result;
        } else {
            return result[1..(result.Length)];
        }
    }
}
