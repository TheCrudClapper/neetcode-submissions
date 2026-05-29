public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
            //BUCKET SORT O(n)
    Dictionary<int, int> count = new Dictionary<int, int>();

    //Creating and array of lists that will contain numbers
    List<int>[] freq = new List<int>[nums.Length + 1];
    for (int i = 0; i < freq.Length; i++)
        freq[i] = [];

    //Counting occurencies
    foreach (int n in nums)
    {
        if (count.ContainsKey(n))
            count[n]++;
        else
            count[n] = 1;
    }

    //Index -> number of occurecies
    //Value -> numbers that has given index ocurrences
    foreach (var entry in count)
    {
        freq[entry.Value].Add(entry.Key);
    }


    int[] res = new int[k];
    int index = 0;
    for (int i = freq.Length - 1; i > 0 && index < k; i--)
    {
        foreach (int n in freq[i])
        {
            res[index++] = n;
            if (index == k)
                return res;
        }
    }

    return res;

}
}