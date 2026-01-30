
public class JumpGame {
    public bool CanJump(int[] nums) {
        int farthest = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (i > farthest) return false;
            farthest = System.Math.Max(farthest, i + nums[i]);
        }
        return true;
    }
}
