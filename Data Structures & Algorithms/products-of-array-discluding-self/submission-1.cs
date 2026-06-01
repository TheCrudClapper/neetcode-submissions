public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] output = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++)
        {
            int product = 1;
            for(int j = 0; j < nums.Length; j++)
            {   
                if(j == i)
                    continue;
                    
                product = product * nums[j];
            }
            Console.WriteLine(product);
            output[i] = product;
        }

        return output;
    }
}