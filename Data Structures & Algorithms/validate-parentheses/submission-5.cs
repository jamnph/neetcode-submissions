public class Solution {
    public bool IsValid(string s) {
        if ((s.Length) % 2 == 1) return false;

        Char[] c = s.ToCharArray();
        Stack<Char> charStack = new Stack<Char>();
        

        for (int i = 0; i < c.Length; i++) {
            if (c[i] == '(' || c[i] == '[' || c[i] == '{') charStack.Push(c[i]);
            else {
                if (charStack.Count == 0) return false;
                char temp = charStack.Peek();
                Console.WriteLine($"top of the stack is {temp}, curent char is {c[i]}");
                if ( (c[i] == ')' && temp == '(') ||
                     (c[i] == ']' && temp == '[') ||
                     (c[i] == '}' && temp == '{')) charStack.Pop();
                else {
                    return false;
                }
            }
        }

        return (charStack.Count == 0);
        
    }
}
