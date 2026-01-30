
public class ContainerWithMostWater {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1, max = 0;
        while (left < right) {
            int area = System.Math.Min(height[left], height[right]) * (right - left);
            max = System.Math.Max(max, area);
            if (height[left] < height[right]) left++;
            else right--;
        }
        return max;
    }
}
