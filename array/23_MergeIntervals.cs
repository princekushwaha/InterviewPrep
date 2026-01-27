using System;
using System.Collections.Generic;

public class Solution {
    public int[][] Merge(int[][] intervals) {
        if (intervals == null || intervals.Length == 0) return Array.Empty<int[]>();
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> result = new();
        int start = intervals[0][0];
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] <= end) {
                end = Math.Max(end, intervals[i][1]);
            } else {
                result.Add(new int[] { start, end });
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }
        result.Add(new int[] { start, end });
        return result.ToArray();
    }
}
