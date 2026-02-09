using System;
using System.Collections.Generic;

public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> firstIndex = new();
        firstIndex[0] = -1;

        int sum = 0;
        int maxLen = 0;

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i] == 1 ? 1 : -1;
            if (firstIndex.ContainsKey(sum)) {
                maxLen = Math.Max(maxLen, i - firstIndex[sum]);
            } else {
                firstIndex[sum] = i;
            }
        }
        return maxLen;
    }
}
