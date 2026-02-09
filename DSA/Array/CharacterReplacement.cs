public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int left = 0, maxFreq = 0, res = 0;
        for (int right = 0; right < s.Length; right++) {
            maxFreq = Math.Max(maxFreq, ++freq[s[right]-'A']);
            while (right - left + 1 - maxFreq > k)
                freq[s[left++]-'A']--;
            res = Math.Max(res, right - left + 1);
        }
        return res;
    }
}