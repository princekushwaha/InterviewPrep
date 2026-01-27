using System;

public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProd = nums[0];
        int minProd = nums[0];
        int result = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] < 0) {
                (maxProd, minProd) = (minProd, maxProd);
            }

            maxProd = Math.Max(nums[i], maxProd * nums[i]);
            minProd = Math.Min(nums[i], minProd * nums[i]);

            result = Math.Max(result, maxProd);
        }
        return result;
    }
}
