using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++) {
            int need = target - nums[i];
            if (map.ContainsKey(need)) {
                return new int[] { map[need], i };
            }
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}
