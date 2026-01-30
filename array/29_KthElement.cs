
public class KthElement {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0, right = nums.Length - 1;
        int target = nums.Length - k;
        while (left <= right) {
            int pivot = Partition(nums, left, right);
            if (pivot == target) return nums[pivot];
            else if (pivot < target) left = pivot + 1;
            else right = pivot - 1;
        }
        return -1;
    }
    int Partition(int[] nums, int left, int right) {
        int pivot = nums[right], i = left;
        for (int j = left; j < right; j++) {
            if (nums[j] < pivot) {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }
        (nums[i], nums[right]) = (nums[right], nums[i]);
        return i;
    }
}
