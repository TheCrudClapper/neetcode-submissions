public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // var res = new Dictionary<string, List<string>>();
        // foreach (var s in strs)
        // {
        //     int[] count = new int[26];
        //     foreach (char c in s)
        //         count[c - 'a']++;
            
        //     string key = string.Join(",", count);
        //     if(!res.ContainsKey(key))
        //         res[key] = new List<string>();

        //     res[key].Add(s);
        // }
        // return res.Values.ToList();

        Dictionary<string, List<string>> dict = new();

        foreach(var word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            var sortedString = new string(chars);

            if(!dict.ContainsKey(sortedString))
                dict[sortedString] = [];
            
            dict[sortedString].Add(word);
        }

        return dict.Values.ToList();
    }
}
