public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
            indices[nums[i]] = i;

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if(indices.ContainsKey(diff) && indices[diff] != i)
            {
                return [i, indices[diff]];
            }
        }

        return [];
    }
}
