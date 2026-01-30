
using System.Collections.Generic;

public class MinMaxArray {
    public List<int> GetMinMax(int[] arr) {
        int min = int.MaxValue, max = int.MinValue;
        foreach (int num in arr) {
            min = System.Math.Min(min, num);
            max = System.Math.Max(max, num);
        }
        return new List<int>{min, max};
    }
}
