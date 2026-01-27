using System;

public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int[] leftMax = new int[n];
        leftMax[0] = 0;

        for (int i = 1; i < n; i++) {
            leftMax[i] = Math.Max(leftMax[i - 1], height[i - 1]);
        }

        int rightMax = 0;
        int water = 0;

        for (int i = n - 1; i >= 0; i--) {
            int minHeight = Math.Min(leftMax[i], rightMax);
            if (minHeight > height[i]) {
                water += minHeight - height[i];
            }
            rightMax = Math.Max(rightMax, height[i]);
        }
        return water;
    }
}
