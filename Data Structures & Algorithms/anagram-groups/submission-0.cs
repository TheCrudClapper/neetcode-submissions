public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var res = new Dictionary<string, List<string>>();
        foreach(var s in strs)
        {
            var chars = s.ToCharArray();
            Array.Sort(chars);
            string sortedString = new(chars);

            if(!res.ContainsKey(sortedString))
                res[sortedString] = [];

            res[sortedString].Add(s);
        }

        return [..res.Values ];
    }
}
