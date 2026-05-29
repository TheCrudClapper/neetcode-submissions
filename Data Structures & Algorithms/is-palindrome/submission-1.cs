public class Solution {
    public bool IsPalindrome(string s) {
        //Standard approach
        // var normalized = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        // var normalizedRev = new string(normalized.Reverse().ToArray());
        // Console.WriteLine(normalized);
        // Console.WriteLine(normalizedRev);

        // return normalized.Equals(normalizedRev);

        //Two pointers
        var normalized = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        int i = 0;
        int j = normalized.Length - 1;

        while(i < j)
        {
            if(normalized[i] != normalized[j])
                return false;

            i++;
            j--;
        }

        return true;

        //Two pointers + ReadOnlySpan

    }
}
