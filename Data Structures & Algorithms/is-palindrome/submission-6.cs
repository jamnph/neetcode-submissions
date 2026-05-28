public class Solution {
    public bool IsPalindrome(string s) {
        // remove non-alphanumeric
        char[] c = s.ToLower().ToCharArray();
        for (int i = 0; i < c.Length; i++) {
            Console.Write(c[i]);
        }
        Console.WriteLine();

        // 2 pointers?
        int inner = 0, outer = c.Length - 1;

        while (outer > inner) {
            if (!Char.IsLetterOrDigit(c[inner])){
                inner++;
                continue;
            }
            if (!Char.IsLetterOrDigit(c[outer])) {
                outer--;
                continue;
            }
            if (c[inner] == c[outer]) 
            {
                Console.WriteLine($"inner: {c[inner]}, outer: {c[outer]} ");
                inner++;
                outer--;
            } else return false;
        }
        /*
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
        */
        return true;

    }
}
