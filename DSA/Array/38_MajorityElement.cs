
public class MajorityElement {
    public int Find(int[] nums) {
        int count = 0, cand = 0;
        foreach (int n in nums) {
            if (count == 0) cand = n;
            count += (n == cand) ? 1 : -1;
        }
        return cand;
    }
}
