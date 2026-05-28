public class Solution {
    public bool IsPalindrome(string s) {
        // remove non-alphanumeric
        char[] c = s.ToLower().ToCharArray();
        List<char> temp = new List<char>();
        Stack<char> charStack = new Stack<char>();

        for (int i = 0; i < c.Length; i++) {
            if (Char.IsLetterOrDigit(c[i])) {
                charStack.Push(c[i]);
                temp.Add(c[i]);
            }
        }

        for (int i = 0; i < temp.Count; i++) {
            if (temp[i] != charStack.Pop()) return false;
        }

        return true;

    }
}
