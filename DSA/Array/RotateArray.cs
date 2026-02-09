public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }
    void Reverse(int[] a, int l, int r) {
        while (l < r)
            (a[l++], a[r--]) = (a[r], a[l]);
    }
}