
using System.Collections.Generic;

public class MergeIntervals {
    public int[][] Merge(int[][] intervals) {
        System.Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
        List<int[]> res = new();
        int start = intervals[0][0], end = intervals[0][1];
        foreach (var it in intervals) {
            if (it[0] <= end) end = System.Math.Max(end, it[1]);
            else {
                res.Add(new int[]{start, end});
                start = it[0]; end = it[1];
            }
        }
        res.Add(new int[]{start, end});
        return res.ToArray();
    }
}
