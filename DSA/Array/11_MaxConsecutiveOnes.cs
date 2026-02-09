using System;

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int maxCount = 0;
        int current = 0;

        foreach (int num in nums) {
            if (num == 1) {
                current++;
                maxCount = Math.Max(maxCount, current);
            } else {
                current = 0;
            }
        }
        return maxCount;
    }
}
