using System;

public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0;
        int sum = 0;
        int result = int.MaxValue;

        for (int right = 0; right < nums.Length; right++) {
            sum += nums[right];
            while (sum >= target) {
                result = Math.Min(result, right - left + 1);
                sum -= nums[left++];
            }
        }
        return result == int.MaxValue ? 0 : result;
    }
}
