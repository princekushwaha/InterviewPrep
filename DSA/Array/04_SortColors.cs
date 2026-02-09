using System;

public class Solution {
    public void SortColors(int[] nums) {
        int low = 0, mid = 0, high = nums.Length - 1;
        while (mid <= high) {
            if (nums[mid] == 0) {
                (nums[low], nums[mid]) = (nums[mid], nums[low]);
                low++; mid++;
            } else if (nums[mid] == 2) {
                (nums[mid], nums[high]) = (nums[high], nums[mid]);
                high--;
            } else {
                mid++;
            }
        }
    }
}
