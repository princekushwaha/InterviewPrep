
using System.Collections.Generic;
using System.Linq;

public class IntersectionOfArrays {
    public int[] Intersection(int[] a, int[] b) {
        HashSet<int> seen = new(a);
        HashSet<int> res = new();
        foreach (int x in b)
            if (seen.Contains(x)) res.Add(x);
        return res.ToArray();
    }
}
