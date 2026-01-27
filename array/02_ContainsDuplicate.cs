using System;
using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new();
        foreach (int num in nums) {
            if (!seen.Add(num)) return true;
        }
        return false;
    }
}
