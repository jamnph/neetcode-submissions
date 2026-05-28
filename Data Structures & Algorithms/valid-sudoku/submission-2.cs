public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var seen = new HashSet<char>();
        
        for (int row = 0; row < 9; row++) {
            for (int col = 0; col < 9; col++) {
                if (board[row][col] == '.') continue;
                else {
                    if (!seen.Add(board[row][col]) ) return false;
                }
            }
            seen.Clear();
        }

        for (int col = 0; col < 9; col++) {
            for (int row = 0; row < 9; row++) {
                if (board[row][col] == '.') continue;
                else {
                    if (!seen.Add(board[row][col]) ) return false;
                }
            }
            seen.Clear();
        }
        
        for (int box = 0; box < 9; box++) {
            /* for (int i = 0; i < 3; i++) {
                if (board[(box / 3) * 3 + i][(box % 3) * 3 + i] == '.') continue;
                else {
                    if (!seen.Add(board[(box / 3) * 3 + i][(box % 3) * 3 + i]) ) return false;
                }
            } */

            for (int row = 0; row < 3; row++) {
                for (int col = 0; col < 3; col++){
                    if (board[(box / 3) * 3 + row][(box % 3) * 3 + col] == '.') continue;
                    else {
                    if (!seen.Add(board[(box / 3) * 3 + row][(box % 3) * 3 + col]) ) return false;
                    }
                }
            }
            seen.Clear();
        }
        return true;

    }
}
