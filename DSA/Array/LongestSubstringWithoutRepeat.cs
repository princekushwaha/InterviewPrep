public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> map = new();
        int left = 0, res = 0;
        for (int right = 0; right < s.Length; right++) {
            if (map.ContainsKey(s[right]) && map[s[right]] >= left)
                left = map[s[right]] + 1;
            map[s[right]] = right;
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}