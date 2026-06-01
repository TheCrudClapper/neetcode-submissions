public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //Brute Force O(n^2)
        // int[] output = new int[nums.Length];

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     int product = 1;
        //     for(int j = 0; j < nums.Length; j++)
        //     {   
        //         if(j == i)
        //             continue;

        //         product = product * nums[j];
        //     }
        //     Console.WriteLine(product);
        //     output[i] = product;
        // }

        // return output;

        //Optimal O(n) Prefix/Suffix
        int[] output = new int[nums.Length];
        
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];

        int prefixNum = 1;
        int suffixNum = 1;
        for(int i = 0; i < nums.Length; i++)
        { 
            prefix[i] = prefixNum;
            Console.WriteLine(prefix[i]);
            prefixNum = prefixNum * nums[i];
        }

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            suffix[i] = suffixNum;
            Console.WriteLine(suffix[i]);
            suffixNum = suffixNum * nums[i];
        }


        for(int i = 0; i < nums.Length; i++)
            output[i] = prefix[i] * suffix[i];
        
        return output;
    }
}