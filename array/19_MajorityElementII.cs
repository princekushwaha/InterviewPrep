using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int cand1 = 0, cand2 = 0;
        int count1 = 0, count2 = 0;

        foreach (int num in nums) {
            if (cand1 == num) count1++;
            else if (cand2 == num) count2++;
            else if (count1 == 0) {
                cand1 = num;
                count1 = 1;
            } else if (count2 == 0) {
                cand2 = num;
                count2 = 1;
            } else {
                count1--;
                count2--;
            }
        }

        count1 = 0; count2 = 0;
        foreach (int num in nums) {
            if (num == cand1) count1++;
            else if (num == cand2) count2++;
        }

        List<int> result = new();
        if (count1 > nums.Length / 3) result.Add(cand1);
        if (count2 > nums.Length / 3) result.Add(cand2);
        return result;
    }
}
