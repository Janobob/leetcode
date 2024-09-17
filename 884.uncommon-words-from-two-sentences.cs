/*
 * @lc app=leetcode id=884 lang=csharp
 *
 * [884] Uncommon Words from Two Sentences
 */

// @lc code=start
public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        var dict = new Dictionary<string, int>();
        AddToDict(dict, s1);
        AddToDict(dict, s2);

        var uncommons = dict
            .Where(x => x.Value == 1)
            .Select(x => x.Key)
            .ToArray();

        return uncommons;
    }

    public void AddToDict(Dictionary<string, int> dict, string s)
    {
        foreach (var word in s.Split(' '))
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
                continue;
            }
            dict.Add(word, 1);
        }
    }
}
// @lc code=end

