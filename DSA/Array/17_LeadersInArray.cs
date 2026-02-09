using System;
using System.Collections.Generic;

public class Solution {
    public IList<int> Leaders(int[] arr) {
        List<int> result = new();
        int maxFromRight = int.MinValue;

        for (int i = arr.Length - 1; i >= 0; i--) {
            if (arr[i] >= maxFromRight) {
                result.Add(arr[i]);
                maxFromRight = arr[i];
            }
        }
        result.Reverse();
        return result;
    }
}
