
public class TrappingRainWater {
    public int Trap(int[] height) {
        int n = height.Length, res = 0;
        int[] left = new int[n];
        left[0] = height[0];
        for (int i = 1; i < n; i++) left[i] = System.Math.Max(left[i-1], height[i]);
        int rightMax = 0;
        for (int i = n-1; i >= 0; i--) {
            rightMax = System.Math.Max(rightMax, height[i]);
            res += System.Math.Max(0, System.Math.Min(left[i], rightMax) - height[i]);
        }
        return res;
    }
}
