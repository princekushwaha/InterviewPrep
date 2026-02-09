
using System.Collections.Generic;

public class MajorityElementII {
    public IList<int> Find(int[] nums) {
        int c1 = 0, c2 = 0, a = 0, b = 1;
        foreach (int n in nums) {
            if (n == a) c1++;
            else if (n == b) c2++;
            else if (c1 == 0) { a = n; c1 = 1; }
            else if (c2 == 0) { b = n; c2 = 1; }
            else { c1--; c2--; }
        }
        List<int> res = new();
        c1 = c2 = 0;
        foreach (int n in nums) {
            if (n == a) c1++;
            else if (n == b) c2++;
        }
        if (c1 > nums.Length/3) res.Add(a);
        if (c2 > nums.Length/3) res.Add(b);
        return res;
    }
}
