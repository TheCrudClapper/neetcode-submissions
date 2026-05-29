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

        return counted.OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
        }

}