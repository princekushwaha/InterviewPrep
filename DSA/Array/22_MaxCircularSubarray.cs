using System;

public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int total = 0;
        int maxSum = nums[0], curMax = 0;
        int minSum = nums[0], curMin = 0;

        foreach (int num in nums) {
            curMax = Math.Max(num, curMax + num);
            maxSum = Math.Max(maxSum, curMax);

            curMin = Math.Min(num, curMin + num);
            minSum = Math.Min(minSum, curMin);

            total += num;
        }

        if (total == minSum) return maxSum;
        return Math.Max(maxSum, total - minSum);
    }
}
