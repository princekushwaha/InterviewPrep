using System;
using System.Collections.Generic;

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> prefixCount = new();
        prefixCount[0] = 1;

        int sum = 0;
        int count = 0;

        foreach (int num in nums) {
            sum += num;
            if (prefixCount.ContainsKey(sum - k)) {
                count += prefixCount[sum - k];
            }
            prefixCount[sum] = prefixCount.GetValueOrDefault(sum, 0) + 1;
        }
        return count;
    }
}
