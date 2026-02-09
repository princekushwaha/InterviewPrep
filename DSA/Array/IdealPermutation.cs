public class Solution {
    public bool IsIdealPermutation(int[] nums) {
        int min = int.MaxValue;
        for (int i = nums.Length - 1; i >= 2; i--) {
            min = Math.Min(min, nums[i]);
            if (nums[i-2] > min) return false;
        }
        return true;
    }
}