public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> indices = new Dictionary<int, int>();

    for(int i = 0; i < nums.Length; i++)
    {
        var diff = target - nums[i];
        if(indices.ContainsKey(diff))
            return [indices[diff], i];
        else
            indices.Add(nums[i], i);
    }

    return [];
    }
}
