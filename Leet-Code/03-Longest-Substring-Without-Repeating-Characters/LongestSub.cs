public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<int, int> longestSub = new Dictionary<int, int>();
        string currentSub = string.Empty;
        int groupId = 1;

        int maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            currentSub = s[i].ToString();
            for (int j = i+1; j < s.Length; j++)
            {
                if (currentSub.Contains(s[j]))
                {
                    break;
                }
                else
                {
                    currentSub += s[j];
                }
            }
            
            longestSub.Add(groupId, currentSub.Length);
            groupId++;
        }

        if (longestSub.Count > 0)
        {
            maxLength = longestSub.Values.Max();
        }

        return maxLength;
    }
}