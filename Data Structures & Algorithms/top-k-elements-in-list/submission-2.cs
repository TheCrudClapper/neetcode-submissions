public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          var counted = new Dictionary<int, int>();
    foreach(var num in nums)
    {
        if(!counted.ContainsKey(num))
            counted.TryAdd(num, 1);
        else   
            counted[num]++;
    }

      List<int> results = [];

    foreach (KeyValuePair<int, int> entry in counted.OrderByDescending(x => x.Value))
    {
        if (results.Count < k)
            results.Add(entry.Key);
    }

    return results
        .ToArray();
    }
}