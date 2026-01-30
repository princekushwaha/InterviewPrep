
using System.Collections.Generic;
using System.Linq;

public class UnionOfArrays {
    public List<int> FindUnion(int[] a, int[] b) {
        HashSet<int> set = new(a);
        foreach (int x in b) set.Add(x);
        return set.ToList();
    }
}
