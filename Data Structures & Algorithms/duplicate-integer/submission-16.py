class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        temp = set()
        for x in nums:
            if x in temp:
                return True
            else:
                temp.add(x)
        return False
        