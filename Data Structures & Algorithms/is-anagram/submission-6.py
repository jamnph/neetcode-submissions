class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t): return False

        s_temp = sorted(list(s))
        t_temp = sorted(list(t))
        for i, t_char in enumerate(t_temp):
            if t_char != s_temp[i]:
                return False
        return True
        